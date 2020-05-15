package ru.prkis.lab.auto.entity;

import javax.persistence.*;

@Entity
@Table(name = "MANUFACTURERS_TABLE")
public class ManufacturersEntity {

    @Id
    //@GeneratedValue(strategy = GenerationType.AUTO)
    @Column(nullable = false, unique = true)
    private Long id_manufacturer;

    @Column(length = 50, nullable = true, unique = true)
    private String name;

    @Column(length = 50, nullable = true, unique = true)
    private String country;

    public long getIdManufacturer() {
        return id_manufacturer;
    }

    public String getName() {
        return name;
    }

    public String getCountry() {
        return country;
    }

    public void setIdManufacturer(long id_manufacturer) {
        this.id_manufacturer = id_manufacturer;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setCountry(String country) {
        this.country = country;
    }
}
