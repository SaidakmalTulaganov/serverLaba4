package ru.prkis.lab.auto.entity;

import javax.persistence.*;

@Entity
@Table(name = "BODIES_ITEM")
public class BodiesItemEntity {

    @Id
    //@GeneratedValue(strategy = GenerationType.AUTO)
    @Column(nullable = false, unique = true)
    private Long id_body;

    @ManyToOne(fetch = FetchType.EAGER)
    private BodiesEntity bodies;

    @Column(length = 50, nullable = true, unique = true)
    private String name;

    @Column
    private Double price;
}
