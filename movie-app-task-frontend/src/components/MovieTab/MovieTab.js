import React from "react";

 import Movies from '../Movies/Movies';
 import Search from '../SearchBar/Search';

class MovieTab extends React.Component {
    constructor(props) {
      super(props);
  
      this.state = {
        movies: [],
        query: ""
      };
  
      this.onInput = this.onInput.bind(this);
    }
  
    onInput(query) {
      this.setState({
        query
      });
  
      this.searchMovie(query);
    }
  
    getPopularMovies() {
      const url = `https://api.themoviedb.org/3/movie/popular?api_key=cfe422613b250f702980a3bbf9e90716`;
  
      fetch(url)
        .then((response) => response.json())
        .then((data) => {
          this.setState({
            movies: data.results
          });
        });
    }
  
    searchMovie(query) {
        if(query === undefined){
            this.onInput("");
        }
      const url = `https://api.themoviedb.org/3/search/movie?query=${query}&api_key=cfe422613b250f702980a3bbf9e90716`;
  
      fetch(url)
        .then((response) => response.json())
        .then((data) => {
          this.setState({
            movies: data.results
          });
        });
    }
  
    componentDidMount() {
      this.getPopularMovies();
    }
  
    render() {
      const { movies, query } = this.state;
      const isSearched = (query) => (item) =>
        !query || item.title.toLowerCase().includes(query.toLowerCase());
    
  
      return (
        <div className="app">
          <Search
            query={query}
            onInput={this.onInput}
            placeholder="Search for Movie Title …"
          />
            <Movies movies={movies.filter(isSearched(query))} />
        </div>
      );
    }
  }
  export default MovieTab;