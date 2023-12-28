import React from 'react';

//MUI Import
import BatteryCharging20Icon from '@mui/icons-material/BatteryCharging20';
import BatteryCharging30Icon from '@mui/icons-material/BatteryCharging30';
import BatteryCharging60Icon from '@mui/icons-material/BatteryCharging60';
import BatteryCharging80Icon from '@mui/icons-material/BatteryCharging80';
import BatteryCharging90Icon from '@mui/icons-material/BatteryCharging90';
import BatteryChargingFullIcon from '@mui/icons-material/BatteryChargingFull';
import ArchiveIcon from '@mui/icons-material/Archive';

export const iconMappings: { [key: string]: React.ReactNode } = {
        'BatteryCharging20': <BatteryCharging20Icon />,
        'BatteryCharging30': <BatteryCharging30Icon />,
        'BatteryCharging60': <BatteryCharging60Icon />,
        'BatteryCharging80': <BatteryCharging80Icon />,
        'BatteryCharging90': <BatteryCharging90Icon />,
        'BatteryChargingFull': <BatteryChargingFullIcon />,
        'Archive': <ArchiveIcon />,
    };