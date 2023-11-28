using Microsoft.MixedReality.Toolkit.UI;
using System;
using TMPro;
using UnityEngine;



    public class ArButton : MonoBehaviour
    {
        public event Action OnButtonClicked;

        [SerializeField] private TextMeshPro _title;

        [SerializeField] private Interactable _interactable;

        private GameObject _prefab;

        public void Initialize(Item config)
        {
            _title.text = config.Title;
            _prefab = config.Prefab;

            _interactable.OnClick.AddListener(ProccessClick);
        }

        private void ProccessClick()
        {
            Instantiate(_prefab);
            //Vector3 pos = new Vector3(1.3f, 0.28f, 2f);
            //_prefab.transform.position = pos;
            OnButtonClicked?.Invoke();
        }
    }

