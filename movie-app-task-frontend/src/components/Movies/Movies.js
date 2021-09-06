import React from 'react';
import PropTypes from 'prop-types';

import Movie from '../Movie/Movie';
import './Movies.css';
import Card from '../Card/Card';


const DUMMY_MOVIES = [
    {
      id: 'm1',
      title: 'Thor',
      release_year:'2021',
      actors: 'James Jason, Max Maxwell, Irina Shayk',
      imageURL: 'https://lumiere-a.akamaihd.net/v1/images/p_thorragnarok_19888_57cddf58.jpeg?region=0%2C0%2C540%2C810',
      rating : 5, 
      description: 'this is description'
    },
    {
      id: 'm2',
      title: 'Black Widow',
      release_year:'2021',
      actors: 'James Jason, Max Maxwell, Irina Shayk',
      imageURL: 'https://lumiere-a.akamaihd.net/v1/images/p_thorragnarok_19888_57cddf58.jpeg?region=0%2C0%2C540%2C810',
      rating : 5,
      description: 'this is description'
    },
    {
      id: 'm3',
      title: 'Iron Man',
      release_year:'2021',
      actors: 'James Jason, Max Maxwell, Irina Shayk',
      imageURL: 'https://lumiere-a.akamaihd.net/v1/images/p_thorragnarok_19888_57cddf58.jpeg?region=0%2C0%2C540%2C810',
      rating : 5, 
      description: 'this is description'
    },
    {
      id: 'm4',
      title: 'Captain America',
      release_year:'2021',
      actors: 'James Jason, Max Maxwell, Irina Shayk',
      imageURL: 'https://lumiere-a.akamaihd.net/v1/images/p_thorragnarok_19888_57cddf58.jpeg?region=0%2C0%2C540%2C810',
      rating : 5, 
      description: 'this is description'
    },
  ];
const Movies = (props) => {
    
        const moviesList = DUMMY_MOVIES.map((movie) => (
          <Movie
            key={movie.id}
            id={movie.id}
            title={movie.title}
            release_year={movie.release_year}
            actors={movie.actors}
            imageURL={movie.imageURL}
            rating={movie.rating}
            description={movie.description}

          />
        ));
      
        return (
          <section className="movies">
            <Card>
              <ul>{moviesList}</ul>
            </Card>
          </section>
        );
      };

  
export default Movies;