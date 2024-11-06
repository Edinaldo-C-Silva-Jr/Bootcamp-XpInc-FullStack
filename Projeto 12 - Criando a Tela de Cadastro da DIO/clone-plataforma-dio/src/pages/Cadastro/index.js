import { useNavigate } from "react-router-dom";
import { MdPerson, MdEmail, MdLock } from "react-icons/md";
import { useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import * as yup from "yup";

import { Header } from "../../components/Header";
import { Input } from "../../components/Input";
import { Button } from "../../components/Button";
import { api } from "../../services/api";

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

const schema = yup.object({
    fullname: yup.string().required("Campo obrigatório!"),
    email: yup
        .string()
        .email("E-mail inválido.")
        .required("Campo obrigatório!"),
    password: yup
        .string()
        .min(6, "Mínimo 6 caracteres.")
        .required("Campo obrigatório!"),
});

const Cadastro = () => {
    const navigate = useNavigate();

    const handleClickHome = () => {
        navigate("/");
    };

    const handleClickSignIn = () => {
        navigate("/login");
    };

    const {
        control,
        handleSubmit,
        formState: { errors },
    } = useForm({
        resolver: yupResolver(schema),
        mode: "onChange",
    });

    const onSubmit = async (formData) => {
        try {
            const novoUsuario = {
                name: formData.fullname,
                enail: formData.email,
                senha: formData.password,
            };
            await api.post(`users`, novoUsuario);
            navigate("/login");
        } catch {
            alert("Aconteceu um erro. Tente novamente.");
        }
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
                        <form onSubmit={handleSubmit(onSubmit)}>
                            <Input
                                name="fullname"
                                placeholder="Nome Completo"
                                leftIcon={<MdPerson />}
                                control={control}
                                errorMessage={errors?.fullname?.message}
                            />
                            <Input
                                name="email"
                                placeholder="E-mail"
                                leftIcon={<MdEmail />}
                                control={control}
                                errorMessage={errors?.email?.message}
                            />
                            <Input
                                name="password"
                                placeholder="Senha"
                                leftIcon={<MdLock />}
                                control={control}
                                type="password"
                                errorMessage={errors?.password?.message}
                            />
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
                            <TextLogin>Já tenho conta.</TextLogin>
                            <TextLinkLogin
                                href="/login"
                                onClick={handleClickSignIn}
                            >
                                Fazer login
                            </TextLinkLogin>
                        </Row>
                    </Wrapper>
                </Column>
            </Container>
        </div>
    );
};

export { Cadastro };
