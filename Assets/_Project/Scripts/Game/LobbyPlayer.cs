using System;
using Game.Data;
using TMPro;
using UnityEngine;

namespace Game
{
    public class LobbyPlayer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _playerName;
        [SerializeField] private SpriteRenderer _isReadyIndicator;
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private Canvas _canvas;


        private MaterialPropertyBlock _propertyBlock;
        private LobbyPlayerData _data;


        private void Start()
        {
            // _propertyBlock = new MaterialPropertyBlock();
            _mainCamera = Camera.main;
            _canvas.worldCamera = _mainCamera;
            
            _playerName.text = _data.GamerTag;
        }

        /// <summary>
        /// Called whenever we receive a new player
        /// </summary>
        public void SetData(LobbyPlayerData data)
        {
            _data = data;
            Debug.Log($"TNam - gamerTag: {_data.GamerTag}");
            _playerName.text = _data.GamerTag;

            if (_data.IsReady)
            {
                if (_isReadyIndicator != null)
                {
                    /*_isReadyIndicator.GetPropertyBlock(_propertyBlock);
                    _propertyBlock.SetColor("_BaseColor", Color.green);
                    _isReadyIndicator.SetPropertyBlock(_propertyBlock);*/
                    _isReadyIndicator.gameObject.SetActive(true);
                    _isReadyIndicator.color = Color.white;
                }
            }
            
            gameObject.SetActive(true);
        }
        
    }
}