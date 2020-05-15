package ru.prkis.lab.auto.entity;

import javax.persistence.*;

@Entity
@Table(name = "CARS_ITEM")
public class CarsItemEntity {

    @Id
    //@GeneratedValue(strategy = GenerationType.AUTO)
    @Column(nullable = false, unique = true)
    private Long id_car;

    @ManyToOne(fetch = FetchType.EAGER)
    private CarsEntity cars;

    @Column(length = 50, nullable = true, unique = true)
    private String name;

    @Column
    private Double price;
}
