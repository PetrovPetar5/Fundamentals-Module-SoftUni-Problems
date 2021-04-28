namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int> { ["shards"] = 0, ["fragments"] = 0, ["motes"] = 0 };
            var junkMaterials = new Dictionary<string, int>();
            bool isObtained = false;

            while (!isObtained)
            {
                string[] elementsAndQuantity = Console.ReadLine().Split();
                string curMaterialName = String.Empty;
                int curMaterialQuantity = 0;

                for (int i = 0; i < elementsAndQuantity.Length; i += 2)
                {
                    curMaterialQuantity = int.Parse(elementsAndQuantity[i]);
                    curMaterialName = elementsAndQuantity[i + 1].ToLower();

                    switch (curMaterialName)
                    {
                        case "shards":
                            AddsQuantityToExistingElement(keyMaterials, curMaterialName, curMaterialQuantity);
                            if (keyMaterials["shards"] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                keyMaterials["shards"] -= 250;
                                isObtained = true;
                                break;
                            }
                            break;

                        case "fragments":
                            AddsQuantityToExistingElement(keyMaterials, curMaterialName, curMaterialQuantity);
                            if (keyMaterials["fragments"] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                keyMaterials["fragments"] -= 250;
                                isObtained = true;
                                break;
                            }
                            break;

                        case "motes":
                            AddsQuantityToExistingElement(keyMaterials, curMaterialName, curMaterialQuantity);
                            if (keyMaterials["motes"] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                keyMaterials["motes"] -= 250;
                                isObtained = true;
                                break;
                            }
                            break;

                        default:
                            ChecksIfDictionaryContainsPair(junkMaterials, curMaterialName, curMaterialQuantity);
                            continue;
                    }

                    if (isObtained)
                    {
                        break;
                    }
                }
            }

            keyMaterials = keyMaterials
                .OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var material in keyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            junkMaterials = junkMaterials.OrderBy(pair => pair.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static void AddsQuantityToExistingElement(Dictionary<string, int> keyMaterials, string curMaterialName, int curMaterialQuantity)
        {
            keyMaterials[curMaterialName] += curMaterialQuantity;
        }
        static void ChecksIfDictionaryContainsPair(Dictionary<string, int> keyMaterials, string curMaterialName, int curMaterialQuantity)
        {
            if (keyMaterials.ContainsKey(curMaterialName))
            {
                keyMaterials[curMaterialName] += curMaterialQuantity;
            }
            else
            {
                keyMaterials.Add(curMaterialName, curMaterialQuantity);
            }
        }
    }
}
