using SUIFW;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Model;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CreateCharacterPanel : BaseUIForm
{
    public struct CreateData
    {
        public string characterOneName { get; set; }
        public string characterTwoName { get; set; }
        public string characterThreeName { get; set; }
        public string playerName { get; set; }
        public string rocaOneType { get; set; }
        public string rocaTwoType { get; set; }
        public string rocaThreeType { get; set; }
    }

    public Button Create_Btn;
    public Text PlayerName;
    public Text CharacterOneName;
    public Text CharacterTwoName;
    public Text CharacterThreeName;
    public Dropdown RocaOneType;
    public Dropdown RocaTwoType;
    public Dropdown RocaThreeType;
    public Text RocaName;
    public Text RocaDes;
    public Text InitDes;
    public Text GrowthDes;
    public Text AbilityOneDes;
    public Text AbilityTowDes;



    private CreateCharacterModel createCharacterModel;

    BaseEventData baseEventData;
    private void Awake()
    {
        Create_Btn.onClick.AddListener(OnCreateClick);
        
        RocaOneType.onValueChanged.AddListener(OnValueChanged);
        RocaTwoType.onValueChanged.AddListener(OnValueChanged);
        RocaThreeType.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnValueChanged(int index)
    {
        CreateCharacterModel.CreateCharacterViewModel model = createCharacterModel.createCharacterViewModels[index];
        RocaName.text = model.raceName;
        RocaDes.text = model.raceDes;
        InitDes.text = model.initValue;
        GrowthDes.text = model.growthValue;
        AbilityOneDes.text = model.raceAbilityOne;
        AbilityTowDes.text = model.raceAbilityTwo;
    }

    public void OnCreateClick()
    {
        createCharacterModel.createCharacterCallback = CreateDataCallback;
    }

    private void CreateDataCallback(CreateData createData)
    {
        createData.playerName = PlayerName.text;
        createData.characterOneName = CharacterOneName.text;
        createData.characterTwoName = CharacterTwoName.text;
        createData.characterThreeName = CharacterThreeName.text;
        createData.rocaOneType = RocaOneType.captionText.text;
        createData.rocaTwoType = RocaTwoType.captionText.text;
        createData.rocaThreeType = RocaThreeType.captionText.text;
    }

    private void InitModel(object viewModel)
    {
        createCharacterModel = (CreateCharacterModel)viewModel;
        for (int i = 0; i < createCharacterModel.createCharacterViewModels.Count; i++)
        {
            Dropdown.OptionData op = new Dropdown.OptionData();
            op.text = createCharacterModel.createCharacterViewModels[i].raceName;
            RocaOneType.options.Add(op);
        }
        RocaOneType.captionText.text = createCharacterModel.createCharacterViewModels[0].raceName;
    }
    public override void UpdatePanel(object viewModel)
    {
        InitModel(viewModel);
    }



}
