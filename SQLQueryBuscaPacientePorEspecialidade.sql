USE Clinica

GO 

SELECT
    a.id_atendimento AS 'Id Atendimento',
	p.id_paciente AS 'Id Paciente',
	p.nome_paciente AS 'Paciente',
    a.data_atendimento AS 'Data do atendimento',
    a.hr_atendimento AS 'Horario do atendimento',
    a.nome_unidade AS 'Unidade',
    a.endereco_unidade AS 'Endereco unidade',
    a.cd_especialidade AS 'Especialidade'
FROM
    Atendimento AS a
INNER JOIN
    Pacientes AS p
    ON a.id_paciente = p.id_paciente
WHERE
    a.cd_especialidade = 1 --codigo da especialidade, caso fosse texto a.cd_especialidade = 'Neurologia'
    AND a.data_atendimento > DATEADD(MONTH, -6, GETDATE());
