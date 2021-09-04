import React from 'react';
import {Link} from 'react-router-dom';
import './Card.css';
function Card({_id,title, imgURL, body}){
    let object = { articleID: _id, imageURL: imgURL, articleTitle: title, articleBody: body};
    return(
        
  <div>
      <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css" integrity="sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ" crossorigin="anonymous"/>

<div class="card">
  <a href="#">
    <div class="img1"><img src="https://m.media-amazon.com/images/I/51+YmMEU1BL._AC_.jpg"></img></div>
    <div class="img2"></div>
    <div class="title">VIKINGS series Season 1 || Epsoide 1</div>
    <div class="text">Now You can watch the first epsoide of the action series Vikings , wish you interesting watch</div>
    <a href="#"><div class="catagory">Series <i        class="fas fa-film"></i></div></a>
    <a href="#"><div class="views">20211  <i class="far fa-eye"></i> </div></a>
  </a>
</div>
  </div>

    );

}

export default Card;