using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class jeffFlix : Form
    {

        List<Movie> movieList = new List<Movie>();
        ImageList ratingImageList = new ImageList();
        //BindingSource movieBinding = new BindingSource();
        string searchQuery = "";

        int numberOfResults = 0;
        public jeffFlix()
        {
            InitializeComponent();

            readMovies(movieList);
            fillMovieListView();

            if (listViewMovies.SelectedItems.Count > 0)
            {
                listViewMovies.HideSelection = false;
                listViewMovies.Items[0].Selected = true;
                listViewMovies.Select();
            }

            //pictureBoxMain.Load("poster ("+  +").jpg");
            pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMain.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictureBoxStars.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStars.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxStars.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void readMovies(List<Movie> movieList)
        {
            movieList.Clear();

            try
            {
                using (StreamReader sr = new StreamReader("movies(5).txt"))
                {
                    //Reads each line from the txt file and splits each word with delimiter ^
                    //then creates an object of movie and adds that to the list of movies
                    while (!sr.EndOfStream)
                    {

                        string[] movieProperties = sr.ReadLine().Split('^');
                        int test = movieProperties.Count();
                        Movie currMovie = new Movie();
                        currMovie.title = movieProperties[0];
                        currMovie.releaseDate = movieProperties[1];
                        currMovie.genre = movieProperties[2];
                        currMovie.location = movieProperties[3];
                        currMovie.rating = movieProperties[4];
                        currMovie.price = movieProperties[5];
                        currMovie.duration = movieProperties[6];
                        currMovie.image = movieProperties[7];
                        currMovie.description = movieProperties[8];
                        if (currMovie.title.ToLower().IndexOf(searchQuery.ToLower()) != -1 || searchQuery == "")
                        {
                            movieList.Add(currMovie);
                        }


                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading movie.txt due to the following exception: " + ex.Message);
            }

        }


        public void fillMovieListView()
        {
            listViewMovies.Items.Clear();
            numberOfResults = 0;
            for (int i = 0; i < movieList.Count(); i++)
            {
                ListViewItem currMovie = new ListViewItem();

                currMovie.Text = (movieList[i].title);
                currMovie.SubItems.Add(movieList[i].releaseDate);
                currMovie.SubItems.Add(movieList[i].genre);
                currMovie.SubItems.Add(movieList[i].location);
                currMovie.SubItems.Add(movieList[i].rating);
                currMovie.SubItems.Add(movieList[i].price);
                currMovie.SubItems.Add(movieList[i].duration);
                //currMovie.ImageIndex = Int32.Parse(movieList[i].rating);

                //Debug.WriteLine(movieList[i].title);
                //if (currMovie.Text.ToLower().IndexOf(searchQuery.ToLower())!= -1 || searchQuery == "")
                //{
                numberOfResults++;
                listViewMovies.Items.Add(currMovie);
                //}

            }
            Debug.WriteLine(searchQuery);
            labelResults.Text = numberOfResults.ToString();
            selectFirstMovieListItem();
        }

        public void searchMovie()
        {
            searchQuery = textBoxSearchBar.Text;
            readMovies(movieList);
            fillMovieListView();
        }

        public void saveToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("movies(5).txt"))
                {
                    for (int i = 0; i<movieList.Count(); i++)
                    {
                        sw.WriteLine(
                                    movieList[i].title + "^" +
                                    movieList[i].releaseDate + "^" +
                                    movieList[i].genre + "^" +
                                    movieList[i].location + "^" +
                                    movieList[i].rating + "^" +
                                    movieList[i].price + "^" +
                                    movieList[i].duration + "^" +
                                    movieList[i].image + "^" +
                                    movieList[i].description
                            );
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing movies(5).txt due to the following exception: " + ex.Message);
            }
        }



        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listViewMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewMovies.SelectedItems.Count > 0)
                {
                    Debug.WriteLine(listViewMovies.SelectedItems[0].Text + " #: " + listViewMovies.SelectedIndices[0] +
                        " #rating: " + listViewMovies.SelectedItems[0].SubItems[4].Text +
                        " #index: " + movieList[listViewMovies.SelectedIndices[0]].title
                        );

                    pictureBoxMain.Load("poster (" + movieList[listViewMovies.SelectedIndices[0]].image + ").jpg");
                    pictureBoxStars.Load("" + listViewMovies.SelectedItems[0].SubItems[4].Text + "stars.png");
                    textBoxDescription.Text = movieList[listViewMovies.SelectedIndices[0]].description;
                }
            }
            catch
            {
                Debug.WriteLine("Index: ");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jeffFlix_Load(object sender, EventArgs e)
        {
            selectFirstMovieListItem();
            toolTip1.SetToolTip(buttonSave, "Saves the current list to the file overwriting anything in the file. BE SURE YOU WANT TO SAVE");
            toolTip1.SetToolTip(buttonLoad, "Loads from the saved file");
            toolTip1.SetToolTip(buttonDelete, "Deletes the selected movie from both the file and the listview");
            toolTip1.SetToolTip(buttonNext, "Preview the next item");
            toolTip1.SetToolTip(buttonPrev, "Preview the previous item");
            toolTip1.SetToolTip(buttonSearch, "Search based on query for TITLE NAME");
            toolTip1.SetToolTip(buttonSubmit, "Submits for validation and if it passes it will update and re-load the list aswell as the file");
            toolTip1.SetToolTip(pictureBoxMain, "Each image is specifically set for each movie, this is NOT randomly generated");
            toolTip1.SetToolTip(labelDescription, "Each movie has it's own set description aswell");
            toolTip1.SetToolTip(labelResults, "This number is based on the list shown and not the total from the file");
            toolTip1.SetToolTip(pictureBoxStars, "I photoshopped each image (total 5) to get good looking stars that are saved to each individual movie");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            selectNextMovieListItem();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchMovie();
        }

        private void jeffFlix_MouseHover(object sender, EventArgs e)
        {

        }

        private void selectFirstMovieListItem()
        {
            if (listViewMovies.Items.Count > 0)
            {
                listViewMovies.HideSelection = false;
                listViewMovies.Items[0].Selected = true;
                //listViewMovies.Select();
            }
        }
        private void selectNextMovieListItem()
        {
            try
            {
                int currIndex = listViewMovies.SelectedIndices[0];
                if (currIndex != numberOfResults-1)
                {
                    listViewMovies.Items[listViewMovies.SelectedIndices[0]].Selected = false;
                    listViewMovies.Items[currIndex + 1].Selected = true;
                }
            }
            catch
            {
                Debug.Write("Could not go to next item");
            }
            //listViewMovies.Items[listViewMovies.SelectedIndices[0]-1].Selected = false;
        }

        private void selectPrevMovieListItem()
        {
            try
            {
                int currIndex = listViewMovies.SelectedIndices[0];
                
                if (currIndex != 0)
                {
                    listViewMovies.Items[listViewMovies.SelectedIndices[0]].Selected = false;
                    listViewMovies.Items[currIndex - 1].Selected = true;
                }
            }
            catch
            {
                Debug.Write("Could not go to previous item");
            }
            //listViewMovies.Items[listViewMovies.SelectedIndices[0]-1].Selected = false;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            selectPrevMovieListItem();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
// TO DO, FINISH INPUT AND VALIDATION
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int checkSumValidation = 0 ;
            Movie currMovie = new Movie();

            labelTitle.ForeColor = System.Drawing.Color.White;
            labelReleaseDate.ForeColor = System.Drawing.Color.White;
            labelGenre.ForeColor = System.Drawing.Color.White;
            labelLocation.ForeColor = System.Drawing.Color.White;
            labelRating.ForeColor = System.Drawing.Color.White;
            labelPrice.ForeColor = System.Drawing.Color.White;
            labelDuration.ForeColor = System.Drawing.Color.White;
            labelDescription2.ForeColor = System.Drawing.Color.White;


            //Title input
            if (textBoxTitle.Text != "")
            {
                currMovie.title = textBoxTitle.Text;
                checkSumValidation++;
            }
            else
            { labelTitle.ForeColor = System.Drawing.Color.Red; }

            //Release date input
            if (textBoxReleaseDate.Text != "")
            {
                currMovie.releaseDate = textBoxReleaseDate.Text;
                checkSumValidation++;
            }
            else
            { labelReleaseDate.ForeColor = System.Drawing.Color.Red; }

            //Genre input
            if (textBoxGenre.Text != "")
            {
                currMovie.genre = textBoxGenre.Text;
                checkSumValidation++;
            }
            else
            { labelGenre.ForeColor = System.Drawing.Color.Red; }

            //Location input
            if (textBoxLocation.Text != "")
            {
                currMovie.location = textBoxLocation.Text;
                checkSumValidation++;
            }
            else
            { labelLocation.ForeColor = System.Drawing.Color.Red; }

            //Rating input
            if (textBoxRating.Text != "" && int.TryParse(textBoxRating.Text, out int res) && res>0 && res<=5)
            {
                currMovie.rating = textBoxRating.Text;
                checkSumValidation++;
            }
            else
            { labelRating.ForeColor = System.Drawing.Color.Red; }

            //Price input
            if (textBoxPrice.Text != "" && int.TryParse(textBoxPrice.Text, out res))
            {
                currMovie.price = textBoxPrice.Text;
                checkSumValidation++;
            }
            else
            { labelPrice.ForeColor = System.Drawing.Color.Red; }

            // Duration input
            if (textBoxDuration.Text != "" && int.TryParse(textBoxDuration.Text, out res))
            {
                currMovie.duration = textBoxDuration.Text;
                checkSumValidation++;
            }
            else
            { labelDuration.ForeColor = System.Drawing.Color.Red; }

            // Description Input
            if (textBoxDescription2.Text != "")
            {
                currMovie.description = textBoxDescription2.Text;
                checkSumValidation++;
            }
            else
            { labelDescription2.ForeColor = System.Drawing.Color.Red; }

            Random r = new Random();
            currMovie.image = r.Next(200).ToString(); // IMAGE IS A RANDOM POSTER BETWEEN 1 - 200

            string newMovieQuery =  currMovie.title + "^" +
                                    currMovie.releaseDate + "^" +
                                    currMovie.genre + "^" +
                                    currMovie.location + "^" +
                                    currMovie.rating + "^" +
                                    currMovie.price + "^" +
                                    currMovie.duration + "^" +
                                    currMovie.image + "^" +
                                    currMovie.description;

            Debug.WriteLine(newMovieQuery);
            // THIS APPENDS THE NEW SUBMITED MOVIE
            try
            {
                using (StreamWriter sw = new StreamWriter("movies(5).txt", true))
                {
                    if (checkSumValidation == 8)
                    {
                        sw.WriteLine(newMovieQuery);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing movies(5).txt due to the following exception: " + ex.Message);
            }
            if (checkSumValidation == 8) { searchMovie(); } // This reloads the list after a new movie has been added
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            searchMovie();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            movieList.RemoveAt(listViewMovies.SelectedIndices[0]);
            saveToFile();
            searchMovie();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBoxSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchMovie();
            }
        }

        private void textBoxSearchBar_Enter(object sender, EventArgs e)
        {

        }
    }
}
