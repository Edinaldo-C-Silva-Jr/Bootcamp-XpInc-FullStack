import styled from "styled-components";

export const Container = styled.div`
    width: 100%;
`

export const InputContainer = styled.div`
    width: 100%;
    height: 40px;

    border: 1px solid #81259d;
    border-radius: 20px;
    overflow: hidden;
    padding: 0 10px;

    & input {
        width: 100%;
        height: 40px;
        border-radius: 20px;
        background-color: transparent;
        border: 0;
        outline: none;
    }
`;

export const ErrorMessage = styled.p`
    color: #ff0000;
    font-size: 12px;
    margin: 5px 0 5px 40px;
`;
