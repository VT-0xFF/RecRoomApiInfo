using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MDGENDFPANL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NBNFMEFICKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object GMKMPAKIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ECFHMBNAHBP<T> : MDGENDFPANL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BEEOPKKKFGP<T> : ECFHMBNAHBP<T>, MDGENDFPANL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool NBNFMEFICKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PCHBFJNJCLM<T> : BEEOPKKKFGP<T>, ECFHMBNAHBP<T>, MDGENDFPANL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BJOOOMJKEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableInt : ECFHMBNAHBP<int>, MDGENDFPANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB5B620", Offset = "0xB5A620", VA = "0x180B5B620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6E74FF0", Offset = "0x6E73FF0", VA = "0x186E74FF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E74F50", Offset = "0x6E73F50", VA = "0x186E74F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : ECFHMBNAHBP<string>, MDGENDFPANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB5B620", Offset = "0xB5A620", VA = "0x180B5B620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9EF2D0", Offset = "0x9EE2D0", VA = "0x1809EF2D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9EF2D0", Offset = "0x9EE2D0", VA = "0x1809EF2D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E75040", Offset = "0x6E74040", VA = "0x186E75040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : BEEOPKKKFGP<InnerType>, ECFHMBNAHBP<InnerType>, MDGENDFPANL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool NBNFMEFICKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object GMKMPAKIOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x248AC90", Offset = "0x2489C90", VA = "0x18248AC90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x49B5F70", Offset = "0x49B4F70", VA = "0x1849B5F70")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x49B5FA0", Offset = "0x49B4FA0", VA = "0x1849B5FA0")]
		public MutableOverridableBase(bool DEFOPLCHCHK, [NotNull] InnerType BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x49B5790", Offset = "0x49B4790", VA = "0x1849B5790", Slot = "15")]
		public void EAJKPPGGHKD(ECFHMBNAHBP<InnerType> OKACLIDCEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x49B5EB0", Offset = "0x49B4EB0", VA = "0x1849B5EB0", Slot = "16")]
		public void GHOCANAKDHH(ECFHMBNAHBP<InnerType> DFABCHNPEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x49B56A0", Offset = "0x49B46A0", VA = "0x1849B56A0", Slot = "17")]
		public virtual void CMJEOBEPHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MBIEDPJEHBA();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void OIDCBCLMALL(ProtobufType NCHBBNNCJNE);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void AIBKBMBLKBL(byte[] EEOBMHKIALE);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x98E930", Offset = "0x98D930", VA = "0x18098E930", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA3A990", Offset = "0xA39990", VA = "0x180A3A990", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9A0", Offset = "0xA399A0", VA = "0x180A3A9A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40E0590", Offset = "0x40DF590", VA = "0x1840E0590")]
		public SerializedMutableOverridableBase(bool DEFOPLCHCHK, InnerType BJDKOHEGDOK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, KGCCIGOBNAB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E74E80", Offset = "0x6E73E80", VA = "0x186E74E80")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E74EE0", Offset = "0x6E73EE0", VA = "0x186E74EE0")]
		public MutableOverridableObscuredInt(bool DEFOPLCHCHK, ObscuredInt BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E74DB0", Offset = "0x6E73DB0", VA = "0x186E74DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E74B50", Offset = "0x6E73B50", VA = "0x186E74B50", Slot = "20")]
		public override void AIBKBMBLKBL(byte[] EEOBMHKIALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E74D00", Offset = "0x6E73D00", VA = "0x186E74D00", Slot = "19")]
		public override void OIDCBCLMALL(KGCCIGOBNAB NCHBBNNCJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E74C20", Offset = "0x6E73C20", VA = "0x186E74C20", Slot = "18")]
		public override KGCCIGOBNAB MBIEDPJEHBA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DLODOMGLCCP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E74A80", Offset = "0x6E73A80", VA = "0x186E74A80")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E74AE0", Offset = "0x6E73AE0", VA = "0x186E74AE0")]
		public MutableOverridableObscuredFloat(bool DEFOPLCHCHK, ObscuredFloat BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E749B0", Offset = "0x6E739B0", VA = "0x186E749B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E74730", Offset = "0x6E73730", VA = "0x186E74730", Slot = "20")]
		public override void AIBKBMBLKBL(byte[] EEOBMHKIALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E748F0", Offset = "0x6E738F0", VA = "0x186E748F0", Slot = "19")]
		public override void OIDCBCLMALL(DLODOMGLCCP NCHBBNNCJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E74800", Offset = "0x6E73800", VA = "0x186E74800", Slot = "18")]
		public override DLODOMGLCCP MBIEDPJEHBA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, DCPIKKAALLG>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E73950", Offset = "0x6E72950", VA = "0x186E73950")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E746C0", Offset = "0x6E736C0", VA = "0x186E746C0")]
		public MutableOverridableObscuredBool(bool DEFOPLCHCHK, ObscuredBool BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E745F0", Offset = "0x6E735F0", VA = "0x186E745F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E742E0", Offset = "0x6E732E0", VA = "0x186E742E0", Slot = "20")]
		public override void AIBKBMBLKBL(byte[] EEOBMHKIALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E744A0", Offset = "0x6E734A0", VA = "0x186E744A0", Slot = "19")]
		public override void OIDCBCLMALL(DCPIKKAALLG NCHBBNNCJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E743B0", Offset = "0x6E733B0", VA = "0x186E743B0", Slot = "18")]
		public override DCPIKKAALLG MBIEDPJEHBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E74560", Offset = "0x6E73560", VA = "0x186E74560", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PCHBFJNJCLM<ObscuredBool>, BEEOPKKKFGP<ObscuredBool>, ECFHMBNAHBP<ObscuredBool>, MDGENDFPANL
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8E50", VA = "0x1808B9E50", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8BA040", Offset = "0x8B9040", VA = "0x1808BA040", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E73950", Offset = "0x6E72950", VA = "0x186E73950")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6E738D0", Offset = "0x6E728D0", VA = "0x186E738D0")]
		public void EAJKPPGGHKD(MutableOverridableDefaultableObscuredBool DFABCHNPEEM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, KGCCIGOBNAB> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4DE6520", Offset = "0x4DE5520", VA = "0x184DE6520", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4DE66C0", Offset = "0x4DE56C0", VA = "0x184DE66C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x42E46C0", Offset = "0x42E36C0", VA = "0x1842E46C0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4DE64E0", Offset = "0x4DE54E0", VA = "0x184DE64E0")]
		public SerializedMutableOverridableObscuredEnum(bool DEFOPLCHCHK, TObsEnum BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4DE62F0", Offset = "0x4DE52F0", VA = "0x184DE62F0", Slot = "18")]
		public sealed override KGCCIGOBNAB MBIEDPJEHBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4DE63E0", Offset = "0x4DE53E0", VA = "0x184DE63E0", Slot = "19")]
		public sealed override void OIDCBCLMALL(KGCCIGOBNAB NCHBBNNCJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4DE6190", Offset = "0x4DE5190", VA = "0x184DE6190", Slot = "20")]
		public sealed override void AIBKBMBLKBL(byte[] EEOBMHKIALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4DE6270", Offset = "0x4DE5270", VA = "0x184DE6270", Slot = "17")]
		public sealed override void CMJEOBEPHJG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FFNPMHPHOGC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E74210", Offset = "0x6E73210", VA = "0x186E74210", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E74250", Offset = "0x6E73250", VA = "0x186E74250", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E74170", Offset = "0x6E73170", VA = "0x186E74170")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E74110", Offset = "0x6E73110", VA = "0x186E74110")]
		public MutableOverridableListObscuredString(bool DEFOPLCHCHK, List<ObscuredString> BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E74070", Offset = "0x6E73070", VA = "0x186E74070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E73A90", Offset = "0x6E72A90", VA = "0x186E73A90", Slot = "17")]
		public override void CMJEOBEPHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E739C0", Offset = "0x6E729C0", VA = "0x186E739C0", Slot = "20")]
		public override void AIBKBMBLKBL(byte[] EEOBMHKIALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E73D00", Offset = "0x6E72D00", VA = "0x186E73D00", Slot = "19")]
		public override void OIDCBCLMALL(FFNPMHPHOGC NCHBBNNCJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E73B20", Offset = "0x6E72B20", VA = "0x186E73B20", Slot = "18")]
		public override FFNPMHPHOGC MBIEDPJEHBA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : ECFHMBNAHBP<Vector3>, MDGENDFPANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB5B620", Offset = "0xB5A620", VA = "0x180B5B620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E75170", Offset = "0x6E74170", VA = "0x186E75170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x470DE40", Offset = "0x470CE40", VA = "0x18470DE40", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB640", Offset = "0x4AAA640", VA = "0x184AAB640")]
		public OverridableVector3(Vector3 BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5084870", Offset = "0x5083870", VA = "0x185084870")]
		public OverridableVector3(bool DEFOPLCHCHK, Vector3 BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E750D0", Offset = "0x6E740D0", VA = "0x186E750D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E750B0", Offset = "0x6E740B0", VA = "0x186E750B0")]
		public static OverridableVector3 ILBKFABDDDI(Vector3 ADMAMDKLPIC)
		{
			return default(OverridableVector3);
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
