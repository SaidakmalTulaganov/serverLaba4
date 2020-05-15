package ru.prkis.lab.auto.entity;

import javax.persistence.*;

@Entity
@Table(name = "BODIES_TABLE")
public class BodiesEntity {

    @Id
    //@GeneratedValue(strategy = GenerationType.AUTO)
    @Column(nullable = false, unique = true)
    private Long id_body;

    @Column(length = 50, nullable = true, unique = true)
    private String name;

    @Column(length = 50, nullable = true, unique = true)
    private String description;

    public long getIdBody() {
        return id_body;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public void setIdBody(long id_body) {
        this.id_body = id_body;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setDescription(String description) {
        this.description = description;
    }
}
