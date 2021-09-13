import React from 'react';
import PropTypes from 'prop-types';
import  { useEffect, useState } from "react";
import Movie from '../Movie/Movie';
import './Movies.css';
import Card from '../Card/Card';
import axios from "axios";

const Movies = (props) => {

  const [movies, setMovies] = useState([]);
  const [toggle, setToggle] = useState(0);

  useEffect(() =>{ getAllMovies();
  },[]);
const url = "https://localhost:5001/"


 const getAllMovies = () => {
  return axios.get(`${url}media/all_movies`).then((response) => {
    console.log(response.data);
    setMovies(response.data);
  });
};

const moviesList = movies.map((movie) => (
  <Movie
    key ={movie.id}
    id={movie.id}
    title={movie.title}
    release_year={movie.release_year}
    actors={movie.Actors}
    imageURL={movie.img_url}
    rating={movie.ratings.rating_value}
    description={movie.description}
//{moviesList}
  />
 
));
  return (

 
    <div>
      <section className="movies">

        <ul>{moviesList}</ul>

      </section>
    </div>

  );
};


export default Movies;