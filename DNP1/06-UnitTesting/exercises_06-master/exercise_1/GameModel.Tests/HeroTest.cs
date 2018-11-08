using System;
using Xunit;

namespace GameModel.Tests
{
    public class HeroTest
    {
        [Fact]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse()
        {

        }
        
        [Fact]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse()
        {

        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {

        }

        [Fact]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly()
        {

        }

        [Fact]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue()
        {

        }

        [Fact]
        public void Attack_WithWeapon_ShouldReturnAttackValue()
        {

        }

        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {

        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {

        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {

        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {

        }
    }
}
