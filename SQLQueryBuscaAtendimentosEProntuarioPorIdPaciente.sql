
USE Clinica

GO 

SELECT
    pc.nome_paciente AS 'Nome',
    pr.descricao_prontuario AS 'Descrição do prontuario',
    a.data_atendimento AS 'Data do atendimento'
FROM
    Pacientes AS pc
INNER JOIN
    Prontuario AS pr
    ON pc.id_paciente = pr.id_paciente
INNER JOIN
    Atendimento AS a
    ON pr.id_atendimento = a.id_atendimento
WHERE
    pc.id_paciente = 123;-- id que deseja buscar 