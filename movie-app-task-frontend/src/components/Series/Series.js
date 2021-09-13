import React from 'react';
import PropTypes from 'prop-types';
import  { useEffect, useState } from "react";
import OneSeries from '../OneSeries/OneSeries';
import './Series.css';
import Card from '../Card/Card';
import axios from "axios";

const Series = (props) => {

  const [series, setSeries] = useState([]);
  const [toggle, setToggle] = useState(0);

  useEffect(() =>{ getTop10Series();
  },[]);
const url = "https://localhost:5001/"


 const getTop10Series = () => {
  return axios.get(`${url}media/ten_series`).then((response) => {
    console.log(response.data);
    setSeries(response.data);
  });
};

const seriesList = series.map((series) => (
  <OneSeries
    key ={series.id}
    id={series.id}
    title={series.title}
    release_year={series.release_year}
    actors={series.Actors}
    imageURL={series.img_url}
    rating={series.ratings}
    description={series.description}
//{moviesList}
  />
 
));
  return (

 
    <div>
      <section className="movies">

        <ul>{seriesList}</ul>

      </section>
    </div>

  );
};


export default Series;