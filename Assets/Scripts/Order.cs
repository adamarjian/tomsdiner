﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodTypes
{

    BREAD,
    MILKSHAKE,
    STEAK

}

[System.Serializable]
public class Order
{

    // A different approach
    // Depending on the food, their time to eat
    // is based on this time frame instead
    public float timeToEat;

    public int incomeFromOrder;

    public List<FoodTypes> FoodOrders;

    public int BreadPrice;
    public int MilkshakePrice;
    public int SteakPrice;

    public Order(int Total)
    {

        // Initialize our Food Order List
        FoodOrders = new List<FoodTypes>();

        // Make sure Total does not go beyond enum length
        if (Total > System.Enum.GetNames(typeof(FoodTypes)).Length) Total = System.Enum.GetNames(typeof(FoodTypes)).Length;

        // Continue adding a new food order until we reached the desired total
        while (FoodOrders.Count != Total)
        {

            // Generate a random food order
            FoodTypes NewFood = GenerateFoodOrder();

            // Determine if that food order has not been added to our list
            if (!FoodOrders.Contains(NewFood)) FoodOrders.Add(NewFood);

        }


        for (int i = 0; i < FoodOrders.Count; i++)
        {

            switch(FoodOrders[i])
            {


                case FoodTypes.BREAD:
                    {

                        incomeFromOrder += BreadPrice;
                        break;
                    }

                case FoodTypes.MILKSHAKE:
                    {

                        incomeFromOrder += MilkshakePrice;
                        break;
                    }
                case FoodTypes.STEAK:
                    {

                        incomeFromOrder += SteakPrice;
                        break;
                    }

            }

        }

    }

    public FoodTypes GenerateFoodOrder()
    {

        // Create a new randomizer
        System.Random randomizer = new System.Random();

        // Always generate to the max number of enums possible
        int randomFood = randomizer.Next(1, System.Enum.GetNames(typeof(FoodTypes)).Length);

        // Return our new randomized food
        return (FoodTypes)randomFood;

    }

}
