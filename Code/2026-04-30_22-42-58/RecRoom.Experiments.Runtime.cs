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
	public class VBXXTWNDKXH : KJDRKBJFPDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly KUGFNPRLCTZ DVXYLOAVTIP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9770070", Offset = "0x976F470", VA = "0x189770070")]
		[UnityEngine.Scripting.Preserve]
		public VBXXTWNDKXH([Inject(null)][NotNull] KUGFNPRLCTZ provider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x40B48E0", Offset = "0x40B3CE0", VA = "0x1840B48E0", Slot = "4")]
		public bool FTWXDPJGYQG<a>([Out] a a) where a : YCISHTSBYDE, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40B49C0", Offset = "0x40B3DC0", VA = "0x1840B49C0", Slot = "5")]
		public bool FTWXDPJGYQG<b>(string a, [Out] b b) where b : YCISHTSBYDE, new()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface YCISHTSBYDE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KUGFNPRLCTZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FTWXDPJGYQG<a>([Out] a a) where a : YCISHTSBYDE, new();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FTWXDPJGYQG<b>(string a, [Out] b b) where b : YCISHTSBYDE, new();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AOIMZSBHNDO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface KJDRKBJFPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FTWXDPJGYQG<a>([Out] a a) where a : YCISHTSBYDE, new();

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FTWXDPJGYQG<b>(string a, [Out] b b) where b : YCISHTSBYDE, new();
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
		public Type HKQPAXZKOBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x976FAF0", Offset = "0x976EEF0", VA = "0x18976FAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x976FD40", Offset = "0x976F140", VA = "0x18976FD40")]
		public FieldOrPropertyInfo(MemberInfo memberInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x976FBF0", Offset = "0x976EFF0", VA = "0x18976FBF0")]
		public object VSWVGZQYENZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x976F770", Offset = "0x976EB70", VA = "0x18976F770")]
		public void CCJTOXJVQPR(object a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x976F930", Offset = "0x976ED30", VA = "0x18976F930")]
		private static bool IIKRXGXDNJN(Type a, object b, [Out] object c)
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
		[Cpp2IlInjected.Address(RVA = "0x976FFD0", Offset = "0x976F3D0", VA = "0x18976FFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9770030", Offset = "0x976F430", VA = "0x189770030")]
		public StatsigExperimentParameterAttribute(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Tested]
	public class MARKAFOORMP : KUGFNPRLCTZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PGEHOVIHFCA<a> where a : YCISHTSBYDE, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public bool UFNKNDQZRPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public CYQDPJHGHJF OHJIMZSNCAO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public PGEHOVIHFCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x745CB60", Offset = "0x745BF60", VA = "0x18745CB60")]
			internal bool NJLGMCDBSUM(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly UQTOQTEIEZW TTSPYWPUEVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, YCISHTSBYDE> RPPEWTVETXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<Type, StatsigExperimentAttribute> VDHQCGLNCST;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x976FEA0", Offset = "0x976F2A0", VA = "0x18976FEA0")]
		[UnityEngine.Scripting.Preserve]
		public MARKAFOORMP([Inject(null)][NotNull] UQTOQTEIEZW statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7AE0", Offset = "0x3BF6EE0", VA = "0x183BF7AE0", Slot = "4")]
		public bool FTWXDPJGYQG<a>([Out] a a) where a : YCISHTSBYDE, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7670", Offset = "0x3BF6A70", VA = "0x183BF7670", Slot = "5")]
		public bool FTWXDPJGYQG<b>(string a, [Out] b b) where b : YCISHTSBYDE, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x976FE50", Offset = "0x976F250", VA = "0x18976FE50", Slot = "6")]
		public void AOIMZSBHNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6EA0", Offset = "0x3BF62A0", VA = "0x183BF6EA0")]
		private bool FERNXWRPJFE<c>([Out] StatsigExperimentAttribute a) where c : YCISHTSBYDE
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6B00", Offset = "0x3BF5F00", VA = "0x183BF6B00")]
		private static void ANFAEFETMSL<d>(d a, TONSGNWZMCS b, Predicate<string> c) where d : YCISHTSBYDE
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
