import React, { useState, useEffect } from 'react';
import PropTypes from 'prop-types';
import Movies from "../Movies/Movies"

import Search from "../SearchBar/Search"
import ReactDOM from "react-dom";
import axios from "axios";
import { Tabs, Tab, Content } from "../tab";
import './Home.css'
export default function Home() {
  const [active, setActive] = useState(0);



  const handleClick = e => {
    const index = parseInt(e.target.id, 0);
    if (index !== active) {
      setActive(index);
    }
  };
  const [movies, setMovies] = useState([]);
  const [media, setMedia] = useState([]);
  const [series, setSeries] = useState([]);


  const [isShow, setIsShow] = React.useState(true);

  const hc = () => {
    setIsShow(!isShow);
  };

  useEffect(() => {
    getTop10Movies();
  }, []);
  const url = "https://localhost:5001/"


  const getTop10Movies = () => {
    return axios.get(`${url}media/ten_movies`).then((response) => {
      console.log(response.data);
      setMovies(response.data);
    });
  };


 


  useEffect(() => {
    getTop10Series();
  }, []);



  const getTop10Series = () => {
    return axios.get(`${url}media/ten_series`).then((response) => {
      console.log(response.data);
      setSeries(response.data);
    });
  };


  const LoadMoreMovies = ()=> {
    return  axios.get(`${url}media/all_movies`).then((response) => {
      console.log(response.data);
      setMovies(response.data);
    });
  };

  const LoadMoreSeries = ()=> {
      return  axios.get(`${url}media/all_series`).then((response) => {
        console.log(response.data);
        setSeries(response.data);
      });
    };
  const LoadAllMedia = ()=> {
    return  axios.get(`${url}media/all`).then((response) => {
      console.log(response.data);
      setMedia(response.data);
    });
  };
  
  return (
    <div className="App">
      <Search placeholder="Search for Movie Title …" ></Search>
      <Tabs >
        <Tab onClick={handleClick} active={active === 0} id={0} >
          Movies
        </Tab>

        <Tab onClick={handleClick} active={active === 1} id={1} >
          TV Series
        </Tab>
      </Tabs>
      <>
        <Content active={active === 0}>
          <Movies movies={movies}></Movies>
          <button class="glow-on-hover" onClick={LoadMoreMovies}>Load more</button>
        </Content>
        <Content active={active === 1}>
          <Movies movies={series}></Movies>
          <button class="glow-on-hover" onClick={LoadMoreMovies}>Load more</button>
        </Content>
      </>
 





    </div>
  );

}