import React from "react";
import { Button } from "../Button";
import logoDio from "../../assets/logo-dio.jpg";

import {
    BuscarInputContainer,
    HeaderContainer,
    Input,
    Menu,
    MenuRight,
    Row,
    Wrapper,
} from "./styles";

const Header = () => {
    return (
        <Wrapper>
            <HeaderContainer>
                <Row>
                    <img src={logoDio} alt="logo da DIO"/>
                    <BuscarInputContainer>
                        <Input placeholder="Buscar..." />
                    </BuscarInputContainer>
                    <Menu>Live Code</Menu>
                    <Menu>Global</Menu>
                </Row>
                <Row>
                    <MenuRight href="#">Home</MenuRight>
                    <Button title="Entrar" />
                    <Button title="Cadastrar" />
                </Row>
            </HeaderContainer>
        </Wrapper>
    );
};

export { Header };
