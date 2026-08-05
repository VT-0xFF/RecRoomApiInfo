using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Configs;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AI.RoomieAI.Personality
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class RoomiePersonalityQuiz : SingletonScriptableObject<RoomiePersonalityQuiz>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const string GameConfigCategory = "RoomieAI.PersonalityQuiz";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Header("Quiz Configuration")]
		[SerializeField]
		[TextArea(3, 5)]
		private string promptTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Space(10f)]
		private List<QuizQuestion> questions;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int NumQuestions
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA064A70", Offset = "0xA063870", VA = "0x18A064A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<QuizQuestion> Questions
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA064380", Offset = "0xA063180", VA = "0x18A064380", Slot = "6")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA0648C0", Offset = "0xA0636C0", VA = "0x18A0648C0")]
		public string GetPromptTemplate(OTIPMTGRWOI gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA0644A0", Offset = "0xA0632A0", VA = "0x18A0644A0")]
		public string GeneratePersonalityPrompt(IReadOnlyList<int> answerIndices, OTIPMTGRWOI gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0649C0", Offset = "0xA0637C0", VA = "0x18A0649C0")]
		public RoomiePersonalityQuiz()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
