import React from 'react';

//MyComponents Import
import Header from '../../Common/Header/Header';
import PopularProducts from '../Home/PopularProducts';
import CategoryMenu from '../../Common/Header/CategoryMenu';

const Home: React.FC = () => {
    return (
        <div>
            <Header />
            <CategoryMenu />
            <PopularProducts />
        </div>
    );
};

export default Home;