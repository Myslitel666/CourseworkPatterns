import React, { useState } from 'react';

//MyComponents Import
import Logo from '../Header/Logo';
import ShopName from './ShopName';
import { useColorMode } from '../../../ColorModeContext';
import MyButton from '../MyButton';

//MUI Import
import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import InputBase from '@mui/material/InputBase';
import SearchIcon from '@mui/icons-material/Search';

const Header: React.FC = () => {
    const { toggleColorMode } = useColorMode();

    return (
        <AppBar position="static">
            <Toolbar>
                <Logo />
                <ShopName />
                <div style={{ flexGrow: 1 }}></div>
                <div style={{
                    display: 'flex', alignItems: 'center',
                    marginRight: '10px'
                }}>
                    <InputBase
                        placeholder={"Search in the WebShop X..."}
                        sx={{
                            width: '300px', backgroundColor: '#F3F3F3',
                            color: "#212121", paddingLeft: '10px',
                            marginRight: '10px'
                        }}
                    />
                    <MyButton
                        variant="contained"
                        color="primary"
                        startIcon={<SearchIcon />}
                        style={{ marginRight: '180px' }}
                    >
                        Search
                    </MyButton>
                </div>
                {/*position: 'static' для исправления багов смещения объектов*/}
                {/*во время увеличения лого*/}
                <MyButton variant="outlined" color="primary"
                    style={{
                        marginRight: '10px',
                        borderWidth: '2px',
                        position: 'static',
                    }}>
                    Sign in
                </MyButton>
                <MyButton variant="outlined" color="primary"
                    style={{
                        marginRight: '-10px',
                        borderWidth: '2px',
                        position: 'static',
                    }}
                >
                    Sign up
                </MyButton>
            </Toolbar>
        </AppBar>
    );
};

export default Header;
