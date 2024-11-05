import React from "react";
import { MdEmail, MdLock } from "react-icons/md";
import { useNavigate } from "react-router-dom";
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
    CriarText,
    EsqueciText,
    Row,
    SubtitleLogin,
    Title,
    TitleLogin,
    Wrapper,
} from "./styles";

const schema = yup.object({
    email: yup
        .string()
        .email("E-mail inválido.")
        .required("Campo obrigatório!"),
    password: yup
        .string()
        .min(6, "Mínimo 6 caracteres.")
        .required("Campo obrigatório!"),
});

const Login = () => {
    const navigate = useNavigate();

    // Utiliza o useForm para implementar o react hook forms.
    const {
        control,
        handleSubmit,
        formState: { errors },
    } = useForm({
        resolver: yupResolver(schema),
        mode: "onChange",
    });

    // Função que define o que fazer quando o botão Submit for usado no form.
    const onSubmit = async (formData) => {
        try {
            const { data } = await api.get(
                `users?email=${formData.email}&senha=${formData.password}`
            );
            if (data.length === 1) {
                console.log(data);
                navigate("/feed");
            } else {
                alert("E-mail ou senha inválidos.");
            }
        } catch {
            alert("Aconteceu um erro. Tente novamente.");
        }
    };

    const handleClickLogin = () => {
        navigate("/feed");
    };

    return (
        <div>
            <Header onClickEntrar={handleClickLogin} />
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
                        <TitleLogin>Faça seu cadastro</TitleLogin>
                        <SubtitleLogin>
                            Faça seu login e make the change._
                        </SubtitleLogin>
                        <form onSubmit={handleSubmit(onSubmit)}>
                            <Input
                                name="email"
                                control={control}
                                errorMessage={errors?.email?.message}
                                placeholder="E-mail"
                                leftIcon={<MdEmail />}
                            />
                            <Input
                                name="password"
                                control={control}
                                errorMessage={errors?.password?.message}
                                placeholder="Senha"
                                type="password"
                                leftIcon={<MdLock />}
                            />
                            <Button title="Entrar" variant="secondary" />
                        </form>
                        <Row>
                            <EsqueciText>Esqueci minha senha</EsqueciText>
                            <CriarText>Criar Conta</CriarText>
                        </Row>
                    </Wrapper>
                </Column>
            </Container>
        </div>
    );
};

export { Login };
