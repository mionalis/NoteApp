using NoteApp;

namespace NoteAppUnitTests
{
	[TestFixture]
	internal class ValueValidatorTest
	{
		[Test]
		public void AssertStringOnLength_ReturnsNull()
		{
			string value = null;
			int maxLength = 10;
			string propertyName = "TestProperty";

			var result = ValueValidator.AssertStringOnLength(
				value,
				maxLength,
				propertyName);

			Assert.That(result, Is.Null);
		}

		[Test]
		public void AssertStringOnLength_ReturnsSameString()
		{
			string value = "Hello";
			int maxLength = 10;
			string propertyName = "TestProperty";

			var result = ValueValidator.AssertStringOnLength(
				value, 
				maxLength,
				propertyName);

			Assert.That(result, Is.EqualTo(value));
		}

		[Test]
		public void AssertStringOnLength_ThrowsArgumentException()
		{
			string value = "ThisIsTooLong";
			int maxLength = 5;
			string propertyName = "TestProperty";

			Assert.Throws<ArgumentException>(
				() => ValueValidator.AssertStringOnLength(
					value, 
					maxLength, 
					propertyName));
		}
	}
}
