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
    public InputField PlayerName;
    public InputField CharacterOneName;
    public InputField CharacterTwoName;
    public InputField CharacterThreeName;
    public Dropdown RocaOneType;
    public Dropdown RocaTwoType;
    public Dropdown RocaThreeType;
    public Text RocaName;
    public Text RocaDes;
    public Text InitDes;
    public Text GrowthDes;
    public Text AbilityOneDes;
    public Text AbilityTowDes;
    public Text PlayerNameIsRepeatOrNull;
    public Text CharacterOneIsRepeatOrNull;
    public Text CharacterTwoIsRepeatOrNull;
    public Text CharacterThreeIsRepeatOrNull;

    private CreateCharacterModel createCharacterModel;

    BaseEventData baseEventData;
    private void Awake()
    {
        Create_Btn.onClick.AddListener(OnCreateClick);
        
        RocaOneType.onValueChanged.AddListener(OnRocaTypeValueChanged);
        RocaTwoType.onValueChanged.AddListener(OnRocaTypeValueChanged);
        RocaThreeType.onValueChanged.AddListener(OnRocaTypeValueChanged);

        PlayerName.onValueChanged.AddListener(OnPlayerNameIsRepeat);
        CharacterOneName.onValueChanged.AddListener(OnCharacterOneIsRepeat);
        CharacterTwoName.onValueChanged.AddListener(OnCharacterTwoIsRepeat);
        CharacterThreeName.onValueChanged.AddListener(OnCharacterThreeIsRepeat);
    }

    private void OnPlayerNameIsRepeat(string name)
    {
        bool NameIsRepeat =  createCharacterModel.NameIsRepeatCallback(name);
        if (NameIsRepeat)
        {
            PlayerNameIsRepeatOrNull.gameObject.SetActive(true);                
        }
        else
        {
            PlayerNameIsRepeatOrNull.gameObject.SetActive(false);
        }
    }
    private void OnCharacterOneIsRepeat(string name)
    {
        bool NameIsRepeat = createCharacterModel.NameIsRepeatCallback(name);
        if (NameIsRepeat)
        {
            CharacterOneIsRepeatOrNull.gameObject.SetActive(true);
        }
        else
        {
            CharacterOneIsRepeatOrNull.gameObject.SetActive(false);
        }
    }
    private void OnCharacterTwoIsRepeat(string name)
    {
        bool NameIsRepeat = createCharacterModel.NameIsRepeatCallback(name);
        if (NameIsRepeat)
        {
            CharacterTwoIsRepeatOrNull.gameObject.SetActive(true);
        }
        else
        {
            CharacterTwoIsRepeatOrNull.gameObject.SetActive(false);
        }
    }
    private void OnCharacterThreeIsRepeat(string name)
    {
        bool NameIsRepeat = createCharacterModel.NameIsRepeatCallback(name);
        if (NameIsRepeat)
        {
            CharacterThreeIsRepeatOrNull.gameObject.SetActive(true);
        }
        else
        {
            CharacterThreeIsRepeatOrNull.gameObject.SetActive(false);
        }
    }

    private void OnRocaTypeValueChanged(int index)
    {
        RocaName.text = createCharacterModel.createCharacterViewModels[index].raceName;
        RocaDes.text = createCharacterModel.createCharacterViewModels[index].raceDes;
        //TODO
        //InitDes.text = createCharacterModel.createCharacterViewModels[index].initValue;
        //GrowthDes.text = createCharacterModel.createCharacterViewModels[index].growthValue;
        AbilityOneDes.text = createCharacterModel.createCharacterViewModels[index].raceAbilityOne;
        AbilityTowDes.text = createCharacterModel.createCharacterViewModels[index].raceAbilityTwo;
    }

    public void OnCreateClick()
    {
        
        bool b = OnPlayerNameIsNull(PlayerName.text);
        bool b1 = OnCharacterOneIsNull(CharacterOneName.text);
        bool b2 = OnCharacterTwoIsNull(CharacterTwoName.text);
        bool b3 = OnCharacterThreeIsNull(CharacterThreeName.text);

        if (b || b1 || b2 || b3)
        {
            return;
        }

        createCharacterModel.CreateCharacterCallback(CreateDataCallback());
    }
    private bool OnPlayerNameIsNull(string name)
    {
        if (name == "" || name == String.Empty)
        {
            PlayerNameIsRepeatOrNull.gameObject.SetActive(true);
            return true;
        }
        else
        {
            PlayerNameIsRepeatOrNull.gameObject.SetActive(false);
            return false;
        }
    }
    private bool OnCharacterOneIsNull(string name)
    {
        if (name == "" || name == String.Empty)
        {
            CharacterOneIsRepeatOrNull.gameObject.SetActive(true);
            return true;
        }
        else
        {
            CharacterOneIsRepeatOrNull.gameObject.SetActive(false);
            return false;
        }
    }
    private bool OnCharacterTwoIsNull(string name)
    {
        if (name == "" || name == String.Empty)
        {
            CharacterTwoIsRepeatOrNull.gameObject.SetActive(true);
            return true;
        }
        else
        {
            CharacterTwoIsRepeatOrNull.gameObject.SetActive(false);
            return false;
        }
    }
    private bool OnCharacterThreeIsNull(string name)
    {
        if (name == "" || name == String.Empty)
        {
            CharacterThreeIsRepeatOrNull.gameObject.SetActive(true);
            return true;
        }
        else
        {
            CharacterThreeIsRepeatOrNull.gameObject.SetActive(false);
            return false;
        }
    }


    private CreateData CreateDataCallback()
    {
        CreateData createData = new CreateData();
        createData.playerName = PlayerName.text;
        createData.characterOneName = CharacterOneName.text;
        createData.characterTwoName = CharacterTwoName.text;
        createData.characterThreeName = CharacterThreeName.text;
        createData.rocaOneType = RocaOneType.captionText.text;
        createData.rocaTwoType = RocaTwoType.captionText.text;
        createData.rocaThreeType = RocaThreeType.captionText.text;
        return createData;
    }

    private void InitModel(object viewModel)
    {
        if (viewModel == null ||!(viewModel is CreateCharacterModel))
        {
            return;
        }
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
