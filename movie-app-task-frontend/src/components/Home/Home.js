import React , { useState }from 'react';
import PropTypes from 'prop-types';
import Movies from "../Movies/Movies"
import Series from "../Series/Series"
import Search from "../SearchBar/Search"
import ReactDOM from "react-dom";
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
  return (
    <div className="App">
<Search placeholder="Search for Movie Title …"></Search>
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
          <Movies></Movies>
        </Content>
        <Content active={active === 1}>
         <Series></Series>
        </Content>
      </>
      {/* <Tabs>
        <TabList>
          <Tab>Title 1</Tab>
          <Tab>Title 2</Tab>
        </TabList>

        <TabPanel>
          <h2>Any content 1</h2>
        </TabPanel>
        <TabPanel>
          <h2>Any content 2</h2>
        </TabPanel>
      </Tabs> */}
    </div>
  );

}