import React from 'react';
import PropTypes from 'prop-types';
import './Movie.css'
import { Card, Icon, Image } from 'semantic-ui-react'



const Movie = (props) => {
    return (
      <Card>
      <Image src={props.imageURL} wrapped ui={false} />
      <Card.Content>
        <Card.Header>{props.title}</Card.Header>
        <Card.Meta>
          <span className='date'>{props.release_year}</span>
        </Card.Meta>
        <Card.Content extra>
        <a>
          <Icon name='user' />
          {props.actors}
        </a>
      </Card.Content>
        <Card.Description>
        {props.description}
        </Card.Description>
      </Card.Content>

    </Card>
  
    );
}
  
   export default Movie;
  