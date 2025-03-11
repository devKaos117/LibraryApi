CREATE TABLE Publishers (
    id int PRIMARY KEY AUTO_INCREMENT,
    TIN varchar(16) NOT NULL,
    FTID_Code varchar(4) NOT NULL,
    name varchar(255) NOT NULL,
    foundation date NOT NULL
);

CREATE TABLE Publisher_Address (
    id int PRIMARY KEY AUTO_INCREMENT,
    Publisher_id int NOT NULL,
    zip_code varchar(16) NOT NULL,
    street_name varchar(255) NOT NULL,
    number varchar(4) NOT NULL,
    complement varchar(255),
    district varchar(255) NOT NULL,
    city varchar(255) NOT NULL,
    state varchar(255)
);

ALTER TABLE Publisher_Address ADD CONSTRAINT FOREIGN KEY (Publisher_id) REFERENCES Publishers (id) ON DELETE CASCADE;