package ru.prkis.lab.auto.entity;

import javax.persistence.*;

@Entity
@Table(name = "CARS_TABLE")
public class CarsEntity {

    @Id
    //@GeneratedValue(strategy = GenerationType.AUTO)
    @Column(nullable = false, unique = true)
    private Long id_car;

    @Column(length = 50, nullable = true, unique = true)
    private Long id_body;

    @Column(length = 50, nullable = true, unique = true)
    private Long id_manufacturer;

    @Column(length = 50, nullable = true, unique = true)
    private Long year;

    @Column(length = 50, nullable = true, unique = true)
    private Long price;

    @Column(length = 50, nullable = true, unique = true)
    private Long quantity;

    @Column(length = 50, nullable = true, unique = true)
    private Long defective;

    public long getIdCar() {
        return id_car;
    }

    public long getIdBody() {
        return id_body;
    }

    public long getIdManufacturer() {
        return id_manufacturer;
    }

    public long getYear() {
        return year;
    }

    public long getPrice() {
        return price;
    }

    public long getQuantity() {
        return quantity;
    }

    public long getDefective() {
        return defective;
    }

    public void setIdCar(long id_car) {
        this.id_car = id_car;
    }

    public void setIdBody(long id_body) {
        this.id_body = id_body;
    }

    public void setIdManufacturer(long id_manufacturer) {
        this.id_manufacturer = id_manufacturer;
    }

    public void setYear(long year) {
        this.year = year;
    }

    public void setPrice(long price) {
        this.price = price;
    }

    public void setQuantity(long quantity) {
        this.quantity = quantity;
    }

    public void setDefective(long defective) {
        this.defective = defective;
    }
}
