package ru.prkis.lab.auto.entity;

import javax.persistence.*;

@Entity
@Table(name = "MANUFACTURERS_ITEM")
public class ManufacturersItemEntity {

    @Id
    //@GeneratedValue(strategy = GenerationType.AUTO)
    @Column(nullable = false, unique = true)
    private Long id_manufacturer;

    @ManyToOne(fetch = FetchType.EAGER)
    private ManufacturersEntity manufacturers;

    @Column(length = 50, nullable = true, unique = true)
    private String name;

    @Column
    private Double price;
}
