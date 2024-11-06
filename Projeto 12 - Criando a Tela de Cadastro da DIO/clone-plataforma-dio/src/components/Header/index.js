import React from "react";
import { Button } from "../Button";
import logoDio from "../../assets/logo-dio.png";

import {
    BuscarInputContainer,
    HeaderContainer,
    Input,
    Menu,
    Row,
    UserPicture,
    Wrapper,
} from "./styles";

const Header = ({
    userImage,
    usuarioAutenticado: userLogado = false,
    showHome = true,
    showEntrar = true,
    showCadastrar = true,
    onClickEntrar = null,
    onClickCadastrar = null,
    onClickHome = null,
}) => {
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
                <Row>
                    {showHome ? ( // Define se o link para Home será exibido.
                        <Button title="Home" onClick={onClickHome} />
                    ) : null}
                    {userLogado ? ( //Se o usuário estiver logado, mostra a foto de perfil dele.
                        <UserPicture src={userImage} />
                    ) : null}
                    {showEntrar ? ( // Define se o botão Entrar será exibido.
                        <Button title="Entrar" onClick={onClickEntrar} />
                    ) : null}
                    {showCadastrar ? ( // Define se o botão Cadastrar será exibido.
                        <Button title="Cadastrar" onClick={onClickCadastrar} />
                    ) : null}
                </Row>
            </HeaderContainer>
        </Wrapper>
    );
};

export { Header };
