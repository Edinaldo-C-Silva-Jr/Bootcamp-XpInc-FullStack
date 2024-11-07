import { Container, LoginContainer, Column, Spacing, Title } from "./styles";

import Button from "../../components/Button";

const Login = () => {
    return (
        <Container>
            <LoginContainer>
                <Column>
                    <Title>Login</Title>
                    <Spacing />
                    <input />
                    <Spacing />
                    <input />
                    <Spacing />
                    <Button title="Entrar"/>
                </Column>
            </LoginContainer>
        </Container>
    );
};

export default Login;
