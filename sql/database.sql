CREATE TABLE empresa (
    rnc_emp NCHAR(15) PRIMARY KEY,
    ide_emp NCHAR(40),
    dir_emp NCHAR(30),
    sec_emp NCHAR(30),
    pro_emp NCHAR(30),
    tel_emp NCHAR(15),
    ema_emp NCHAR(30)
);

CREATE TABLE usuario (
    cod_usu INT PRIMARY KEY,
    nom_usu NCHAR(30),
    tip_usu INT,
    cla_usu NCHAR(10),
    cel_usu NCHAR(10),
    cor_usu NCHAR(30)
);

CREATE TABLE nomina (
    cod_emp INT PRIMARY KEY,
    nom_emp NCHAR(30),
    ape_emp NCHAR(30),
    sue_bas DECIMAL(18, 2),
    afp_emp DECIMAL(18, 2),
    ars_emp DECIMAL(18, 2),
    isr_emp DECIMAL(18, 2),
    tde_emp DECIMAL(18, 2),
    sue_net DECIMAL(18, 2)
);

CREATE TABLE Calificacion (
    mat_est INT PRIMARY KEY,
    nom_est NCHAR(20),
    ape_est NCHAR(20),
    asi_est NCHAR(50),
    poe INT,
    pf INT,
    ap INT,
    va INT,
    pef INT,
    nf INT,
    L NCHAR(1),
    con NCHAR(15)
);
