import React from 'react';
import PropTypes from 'prop-types';
import './Movie.css'




const Movie = (props) => {
    return (
        <div>
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css" integrity="sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ" crossorigin="anonymous"/>
  
  <div class="card">
    <a href="#">
      <div class="img1"><img src=""></img></div>
      <div class="img2"></div>
      <div class="title">{props.title}</div>
      <div class="text">{props.description}</div>
      <a href="#"><div class="catagory">Series <i        class="fas fa-film"></i></div></a>
      <a href="#"><div class="views">{props.release_year}  <i class="far fa-eye"></i> </div></a>
    </a>
  </div>
    </div>
  
    );
}
  
   export default Movie;
  