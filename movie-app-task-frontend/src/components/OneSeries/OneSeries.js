import React from 'react';
import PropTypes from 'prop-types';
import './OneSeries.css'
import { Card, Icon, Image } from 'semantic-ui-react'

import { makeStyles } from '@material-ui/core/styles';
import Rating from '@material-ui/lab/Rating';
import Box from '@material-ui/core/Box';
import Api from "../../API/API_calls"
const OneSeries = (props) => {

  const labels = {
    0.5: 'Useless',
    1: 'Useless+',
    1.5: 'Poor',
    2: 'Poor+',
    2.5: 'Ok',
    3: 'Ok+',
    3.5: 'Good',
    4: 'Good+',
    4.5: 'Excellent',
    5: 'Excellent+',
  };
  
  const useStyles = makeStyles({
    root: {
      width: 200,
      display: 'flex',
      alignItems: 'center',
    },
  });
  const [value, setValue] = React.useState(2);
  const [hover, setHover] = React.useState(-1);
  const classes = useStyles();


  
  return (
    <Card >
      <Image src={props.imageURL} wrapped ui={false} className="img" />
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
      <Rating
        name="hover-feedback"
        value={value}
        precision={0.5}
        onChange={(event, newValue) => {
          setValue(newValue);
        }}
        onChangeActive={(event, newHover) => {
          setHover(newHover);
        }}
      />
      {value !== null && <Box ml={2}>{labels[hover !== -1 ? hover : value]}</Box>}
    </Card>

  );
}

export default OneSeries;
