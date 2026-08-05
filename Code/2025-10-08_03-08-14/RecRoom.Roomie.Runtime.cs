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
			[Cpp2IlInjected.Address(RVA = "0x8D9B3E0", Offset = "0x8D9A1E0", VA = "0x188D9B3E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<QuizQuestion> Questions
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D9ACF0", Offset = "0x8D99AF0", VA = "0x188D9ACF0", Slot = "6")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D9B230", Offset = "0x8D9A030", VA = "0x188D9B230")]
		public string GetPromptTemplate(YEADHGPVUSS gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D9AE10", Offset = "0x8D99C10", VA = "0x188D9AE10")]
		public string GeneratePersonalityPrompt(IReadOnlyList<int> answerIndices, YEADHGPVUSS gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D9B330", Offset = "0x8D9A130", VA = "0x188D9B330")]
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
