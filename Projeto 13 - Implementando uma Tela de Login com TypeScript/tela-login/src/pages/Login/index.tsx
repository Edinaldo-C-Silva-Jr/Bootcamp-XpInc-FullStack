import { useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import * as yup from "yup";

import { Container, LoginContainer, Column, Spacing, Title } from "./styles";
import { IFormLogin, defaultValues } from "./types";

import Button from "../../components/Button";
import Input from "../../components/Input";

const schema = yup
    .object({
        email: yup
            .string()
            .email("E-mail inválido.")
            .required("Campo obrigatório."),
        password: yup
            .string()
            .min(6, "Senha deve ter pelo menos 6 caracteres.")
            .required("Campo obrigatório."),
    })
    .required();

const Login = () => {
    const {
        control,
        formState: { errors, isValid },
    } = useForm<IFormLogin>({
        resolver: yupResolver(schema),
        mode: "onBlur",
        defaultValues,
        reValidateMode: "onChange",
    });

    return (
        <Container>
            <LoginContainer>
                <Column>
                    <Title>Login</Title>
                    <Spacing />
                    <Input
                        name="email"
                        placeholder="E-mail"
                        control={control}
                        errorMessage={errors?.email?.message}
                    />
                    <Spacing />
                    <Input
                        name="password"
                        placeholder="Senha"
                        type="password"
                        control={control}
                        errorMessage={errors?.password?.message}
                    />
                    <Spacing />
                    <Button isValid={isValid} title="Entrar" />
                    <button disabled={true} />
                </Column>
            </LoginContainer>
        </Container>
    );
};

export default Login;
