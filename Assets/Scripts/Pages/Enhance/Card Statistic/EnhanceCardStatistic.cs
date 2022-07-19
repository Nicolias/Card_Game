using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Enhance.Card_Statistic
{
    public abstract class EnhanceCardStatistic : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private Image _frameImage;
        [SerializeField] private Sprite _standartImage;
        [SerializeField] private TMP_Text _atk, _def, _rarity, _race, _name, _health, _level;

        protected virtual void OnDisable()
        {
            _icon.sprite = _standartImage;
            _frameImage.gameObject.SetActive(false);

            _atk.text = "";
            _def.text = "";
            _health.text = "";
            _level.text = "";
            _race.text = "";
            _rarity.text = "";
            _name.text = "";
        }

        public void Render(CardCell cardForDelete)
        {
            _icon.sprite = cardForDelete.Icon.sprite;
            _frameImage.sprite = cardForDelete.Card.GetFrame();
            _frameImage.gameObject.SetActive(true);

            _atk.text = "ATK: " + cardForDelete.Attack;
            _def.text = "DEF: " + cardForDelete.Def;
            _health.text = "HP: " + cardForDelete.Health;
            _level.text = "Level: " + cardForDelete.Level;
            _race.text = cardForDelete.Card.Race.ToString();
            _rarity.text = cardForDelete.Card.Rarity.ToString();
            _name.text = cardForDelete.Card.Name;
        }
    }
}
