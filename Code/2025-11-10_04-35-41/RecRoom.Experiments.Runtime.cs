using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Analytics.Statsig;
using RecRoom.NoEngine.Common;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Experiments
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Tested]
	public class JOJCDTGAIZL : KXXINMAYJHY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly LOWNVDIUPFB IGFPCUTJBRF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8268340", Offset = "0x8267740", VA = "0x188268340")]
		[UnityEngine.Scripting.Preserve]
		public JOJCDTGAIZL([Inject(null)][NotNull] LOWNVDIUPFB provider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x36E1740", Offset = "0x36E0B40", VA = "0x1836E1740", Slot = "4")]
		public bool AJCQLVMZTZA<a>([Out] a a) where a : XXCGAYMPLNM, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x36E1660", Offset = "0x36E0A60", VA = "0x1836E1660", Slot = "5")]
		public bool AJCQLVMZTZA<b>(string a, [Out] b b) where b : XXCGAYMPLNM, new()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XXCGAYMPLNM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface LOWNVDIUPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AJCQLVMZTZA<a>([Out] a a) where a : XXCGAYMPLNM, new();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AJCQLVMZTZA<b>(string a, [Out] b b) where b : XXCGAYMPLNM, new();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KCGZBLHQNMU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface KXXINMAYJHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AJCQLVMZTZA<a>([Out] a a) where a : XXCGAYMPLNM, new();

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AJCQLVMZTZA<b>(string a, [Out] b b) where b : XXCGAYMPLNM, new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Field)]
	public class NotExperimentParameterAttribute : Attribute
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal readonly struct FieldOrPropertyInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly MemberInfo memberInfo;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type XEYXWGRJHBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8267E20", Offset = "0x8267220", VA = "0x188267E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8268230", Offset = "0x8267630", VA = "0x188268230")]
		public FieldOrPropertyInfo(MemberInfo memberInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8267F20", Offset = "0x8267320", VA = "0x188267F20")]
		public object WNIKEIXLQNZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8268070", Offset = "0x8267470", VA = "0x188268070")]
		public void WVRERNDGVJJ(object a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8267C60", Offset = "0x8267060", VA = "0x188267C60")]
		private static bool AZVEDTSVZIP(Type a, object b, [Out] object c)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Experiments.Providers
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum StatsigExperimentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Experiment,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Layer
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class StatsigExperimentAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly bool UseLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly StatsigExperimentType Type;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82683D0", Offset = "0x82677D0", VA = "0x1882683D0")]
		public StatsigExperimentAttribute([Optional] string name, StatsigExperimentType type = StatsigExperimentType.Experiment, bool useLayerDefaults = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class StatsigExperimentParameterAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8268430", Offset = "0x8267830", VA = "0x188268430")]
		public StatsigExperimentParameterAttribute(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Tested]
	public class AXTADXVFNOL : LOWNVDIUPFB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AXMCKBVVHNS<a> where a : XXCGAYMPLNM, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public bool MRPHYACXYBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public MRVVHUVMMYD CDVZVBWPSVE;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AXMCKBVVHNS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x55095C0", Offset = "0x55089C0", VA = "0x1855095C0")]
			internal bool OLQXYYZNTYY(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CTVUVETPQOE QQJNVIGIPXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, XXCGAYMPLNM> TJNRBPTXNHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<Type, StatsigExperimentAttribute> OICBVUVQZFZ;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8267B30", Offset = "0x8266F30", VA = "0x188267B30")]
		[UnityEngine.Scripting.Preserve]
		public AXTADXVFNOL([Inject(null)][NotNull] CTVUVETPQOE statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3027E60", Offset = "0x3027260", VA = "0x183027E60", Slot = "4")]
		public bool AJCQLVMZTZA<a>([Out] a a) where a : XXCGAYMPLNM, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3027F00", Offset = "0x3027300", VA = "0x183027F00", Slot = "5")]
		public bool AJCQLVMZTZA<b>(string a, [Out] b b) where b : XXCGAYMPLNM, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8267AE0", Offset = "0x8266EE0", VA = "0x188267AE0", Slot = "6")]
		public void KCGZBLHQNMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3028370", Offset = "0x3027770", VA = "0x183028370")]
		private bool FWLRRYEUJVE<c>([Out] StatsigExperimentAttribute a) where c : XXCGAYMPLNM
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30288D0", Offset = "0x3027CD0", VA = "0x1830288D0")]
		private static void VFMMYDUNAPR<d>(d a, RZTWUVTWFIS b, Predicate<string> c) where d : XXCGAYMPLNM
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
