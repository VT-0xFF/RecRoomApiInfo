using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AI.RoomieAI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum RoomieEnergyMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Undefined = -1,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		LowEnergy,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		HighEnergy
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IRoomieManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum PersonalityQuizActionType
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			Skip,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			Done
		}

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool HasAccessToRoomieAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool SupportNoEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool SupportLowEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		RoomieEnergyMode RoomieEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IsInNoCreditErrorMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsRoomieOptionVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string RoomieAccessError
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool HasDoneFirstConnectionThisRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool HasDoneFirstConnectionThisSession
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool HasDoneFirstConnection
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool WasRoomieAutoSpawned
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool IsRoomieInHighEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool IsRoomieInLowEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		YVFAYFMDPIA<bool> OnAccessToRoomieAIChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		YVFAYFMDPIA<RoomieEnergyMode> OnRoomieEnergyModeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void DisplayRoomieStorePage();

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<bool> TrySpawnRoomie();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool ShouldAutoSpawn();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void UpdateAutoSpawn(bool enable);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool TryUpdateRoomieEnergyMode(RoomieEnergyMode mode);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void LogRoomiePersonalityQuizAction(PersonalityQuizActionType actionType, IReadOnlyList<int> optionIndices);
	}
}
namespace RecRoom.AI.RoomieAI.Personality
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface IRoomiePersonality
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		VYROOIAXTCX OnPersonalityChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string PersonalityPrompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool HasBeenShownPersonalityQuiz
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<int> QuizAnswerIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool PersonalityReminderEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string PersonalityReminderPrompt
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SetQuizAnswers(IReadOnlyList<int> answerIndices, bool suppressQuip = false);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class QuizAnswer
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string GameConfigCategory = "RoomieAI.PersonalityQuiz.Answers";

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private string answerText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[TextArea(2, 6)]
		private string componentValue;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C990B0", Offset = "0x8C97EB0", VA = "0x188C990B0")]
		public string GetAnswerText(KGLLEZZZDUK gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C99160", Offset = "0x8C97F60", VA = "0x188C99160")]
		public string GetAnswerValue(KGLLEZZZDUK gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public QuizAnswer()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class QuizQuestion
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const string GameConfigCategory = "RoomieAI.PersonalityQuiz.Questions";

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private string question;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private string componentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private List<QuizAnswer> answers;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string ComponentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<QuizAnswer> Answers
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C99210", Offset = "0x8C98010", VA = "0x188C99210")]
		public string GetQuestion(KGLLEZZZDUK gameConfigsProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C992C0", Offset = "0x8C980C0", VA = "0x188C992C0")]
		public QuizQuestion()
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
