import { useNavigate } from "react-router-dom";
import { MdPerson, MdEmail, MdLock } from "react-icons/md";

import { Header } from "../../components/Header";
import { Input } from "../../components/Input";
import { Button } from "../../components/Button";

import {
    Column,
    Container,
    SubtitleLogin,
    Row,
    TextLinkLogin,
    TextLogin,
    Title,
    TitleLogin,
    Wrapper,
} from "./styles";

const Cadastro = () => {
    const navigate = useNavigate();

    const handleClickHome = () => {
        navigate("/");
    };

    const handleClickSignIn = () => {
        navigate("/login");
    };

    return (
        <div>
            <Header
                showCadastrar={false}
                onClickHome={handleClickHome}
                onClickEntrar={handleClickSignIn}
            />
            <Container>
                <Column>
                    <Title>
                        A plataforma para você aprender com experts, dominar as
                        principais tecnologias e entrar mais rápido nas empresas
                        mais desejadas.
                    </Title>
                </Column>
                <Column>
                    <Wrapper>
                        <TitleLogin>Comece agora grátis</TitleLogin>
                        <SubtitleLogin>
                            Crie sua conta e male the change._
                        </SubtitleLogin>
                        <form>
                            <Input name="fullname" leftIcon={<MdPerson />} />
                            <Input name="email" leftIcon={<MdEmail />} />
                            <Input name="password" leftIcon={<MdLock />} />
                            <Button
                                title="Criar minha conta"
                                variant="secondary"
                            />
                        </form>
                        <SubtitleLogin>
                            Ao clicar em "criar minha conta grátis", declaro que
                            aceito as Políticas de Privacidade e os Termos de
                            Uso da DIO.
                        </SubtitleLogin>
                        <Row>
                            <TextLogin>Já tenho conta. </TextLogin>
                            <TextLinkLogin href="/login" onClick={handleClickSignIn}>Fazer login</TextLinkLogin>
                        </Row>
                    </Wrapper>
                </Column>
            </Container>
        </div>
    );
};

export { Cadastro };
