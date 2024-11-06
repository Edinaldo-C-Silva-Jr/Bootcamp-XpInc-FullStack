import React from "react";
import { Button } from "../Button";
import logoDio from "../../assets/logo-dio.png";

import {
    BuscarInputContainer,
    HeaderContainer,
    Input,
    Menu,
    MenuRight,
    Row,
    UserPicture,
    Wrapper,
} from "./styles";

const Header = ({ usuarioAutenticado = false, userImage, onClickEntrar = null, onClickSair = null}) => {
    return (
        <Wrapper>
            <HeaderContainer>
                <Row>
                    <img src={logoDio} alt="logo da DIO" />
                    <BuscarInputContainer>
                        <Input placeholder="Buscar..." />
                    </BuscarInputContainer>
                    <Menu href="#">Live Code</Menu>
                    <Menu href="#">Global</Menu>
                </Row>
                {usuarioAutenticado ? ( //Se o usuário estiver logado, mostra a foto de perfil dele.
                    <Row>
                        <UserPicture src={userImage} />
                        <Button title="Sair" variant="tertiary" onClick={onClickSair}/>
                    </Row>
                ) : (
                    <Row>
                        <MenuRight href="#">Home</MenuRight>
                        <Button title="Entrar" onClick={onClickEntrar}/>
                        <Button title="Cadastrar" onClick={onClickEntrar}/>
                    </Row>
                )}
            </HeaderContainer>
        </Wrapper>
    );
};

export { Header };
