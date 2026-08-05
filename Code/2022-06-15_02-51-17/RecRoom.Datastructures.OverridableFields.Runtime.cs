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
public interface OBNJNLGIFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IPJHKCAFAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JKIKDOIHEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FHAHOEIMODC<T> : OBNJNLGIFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JDLEGGLLANM<T> : global::FHAHOEIMODC<T>, OBNJNLGIFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IPJHKCAFAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OverridableInt : global::FHAHOEIMODC<int>, OBNJNLGIFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x932D80", Offset = "0x931980", VA = "0x180932D80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4E26010", Offset = "0x4E24C10", VA = "0x184E26010", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7844F0", Offset = "0x7830F0", VA = "0x1807844F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E25F90", Offset = "0x4E24B90", VA = "0x184E25F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableString : global::FHAHOEIMODC<string>, OBNJNLGIFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x932D80", Offset = "0x931980", VA = "0x180932D80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x81CED0", Offset = "0x81BAD0", VA = "0x18081CED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x81CED0", Offset = "0x81BAD0", VA = "0x18081CED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E26060", Offset = "0x4E24C60", VA = "0x184E26060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::JDLEGGLLANM<InnerType>, global::FHAHOEIMODC<InnerType>, OBNJNLGIFNK where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract bool IPJHKCAFAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract InnerType HNBDKKLMMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object JKIKDOIHEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28FC990", Offset = "0x28FB590", VA = "0x1828FC990", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28FC770", Offset = "0x28FB370", VA = "0x1828FC770")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28FC820", Offset = "0x28FB420", VA = "0x1828FC820")]
		public MutableOverridableBase(bool MCOLPCPBKJO, [NotNull] InnerType ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28FBD80", Offset = "0x28FA980", VA = "0x1828FBD80", Slot = "15")]
		public void DAJOJNIIELF(global::FHAHOEIMODC<InnerType> CJALHGLOINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28FC3A0", Offset = "0x28FAFA0", VA = "0x1828FC3A0", Slot = "16")]
		public void IGKNEDCEIBH(global::FHAHOEIMODC<InnerType> PJEOMNDGEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28FC140", Offset = "0x28FAD40", VA = "0x1828FC140", Slot = "17")]
		public virtual void EELNFKPNBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType ECBBBBDPAJE();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void GCMDHGECBGE(ProtobufType NELNJPNICAC);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void MCLIHLMJBKH(byte[] JIGLDGJNMDK);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5877B0", Offset = "0x5863B0", VA = "0x1805877B0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DE8C0", Offset = "0x5DD4C0", VA = "0x1805DE8C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1117DF0", Offset = "0x11169F0", VA = "0x181117DF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDE0", Offset = "0x1CFC9E0", VA = "0x181CFDDE0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2905CD0", Offset = "0x29048D0", VA = "0x182905CD0")]
		public SerializedMutableOverridableBase(bool MCOLPCPBKJO, InnerType ODCJDJDBONO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, ANAPPNPNGFF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2906140", Offset = "0x2904D40", VA = "0x182906140", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2906220", Offset = "0x2904E20", VA = "0x182906220", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFFF0", Offset = "0x1EEEBF0", VA = "0x181EEFFF0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2906110", Offset = "0x2904D10", VA = "0x182906110")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x29060E0", Offset = "0x2904CE0", VA = "0x1829060E0")]
		public SerializedMutableOverridableObscuredEnum(bool MCOLPCPBKJO, TObsEnum ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2905DC0", Offset = "0x29049C0", VA = "0x182905DC0", Slot = "18")]
		public sealed override ANAPPNPNGFF ECBBBBDPAJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2905EE0", Offset = "0x2904AE0", VA = "0x182905EE0", Slot = "19")]
		public sealed override void GCMDHGECBGE(ANAPPNPNGFF NELNJPNICAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2905FF0", Offset = "0x2904BF0", VA = "0x182905FF0", Slot = "20")]
		public sealed override void MCLIHLMJBKH(byte[] JIGLDGJNMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2905E80", Offset = "0x2904A80", VA = "0x182905E80", Slot = "17")]
		public sealed override void EELNFKPNBAN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, ANAPPNPNGFF>
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4E25F20", Offset = "0x4E24B20", VA = "0x184E25F20")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E25EB0", Offset = "0x4E24AB0", VA = "0x184E25EB0")]
		public MutableOverridableObscuredInt(bool MCOLPCPBKJO, ObscuredInt ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4E25E00", Offset = "0x4E24A00", VA = "0x184E25E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4E25D10", Offset = "0x4E24910", VA = "0x184E25D10", Slot = "20")]
		public override void MCLIHLMJBKH(byte[] JIGLDGJNMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4E25C50", Offset = "0x4E24850", VA = "0x184E25C50", Slot = "19")]
		public override void GCMDHGECBGE(ANAPPNPNGFF NELNJPNICAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E25B80", Offset = "0x4E24780", VA = "0x184E25B80", Slot = "18")]
		public override ANAPPNPNGFF ECBBBBDPAJE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, EBOMHHNOHCO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4E25AA0", Offset = "0x4E246A0", VA = "0x184E25AA0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E25B10", Offset = "0x4E24710", VA = "0x184E25B10")]
		public MutableOverridableObscuredFloat(bool MCOLPCPBKJO, ObscuredFloat ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4E259F0", Offset = "0x4E245F0", VA = "0x184E259F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4E25900", Offset = "0x4E24500", VA = "0x184E25900", Slot = "20")]
		public override void MCLIHLMJBKH(byte[] JIGLDGJNMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4E25830", Offset = "0x4E24430", VA = "0x184E25830", Slot = "19")]
		public override void GCMDHGECBGE(EBOMHHNOHCO NELNJPNICAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4E25750", Offset = "0x4E24350", VA = "0x184E25750", Slot = "18")]
		public override EBOMHHNOHCO ECBBBBDPAJE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, JDNLPKFLLEB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4E25680", Offset = "0x4E24280", VA = "0x184E25680")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4E256E0", Offset = "0x4E242E0", VA = "0x184E256E0")]
		public MutableOverridableObscuredBool(bool MCOLPCPBKJO, ObscuredBool ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4E255D0", Offset = "0x4E241D0", VA = "0x184E255D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4E254E0", Offset = "0x4E240E0", VA = "0x184E254E0", Slot = "20")]
		public override void MCLIHLMJBKH(byte[] JIGLDGJNMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4E25420", Offset = "0x4E24020", VA = "0x184E25420", Slot = "19")]
		public override void GCMDHGECBGE(JDNLPKFLLEB NELNJPNICAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4E25340", Offset = "0x4E23F40", VA = "0x184E25340", Slot = "18")]
		public override JDNLPKFLLEB ECBBBBDPAJE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, AKPAGNBMDEP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4E25290", Offset = "0x4E23E90", VA = "0x184E25290", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4E252D0", Offset = "0x4E23ED0", VA = "0x184E252D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4E25210", Offset = "0x4E23E10", VA = "0x184E25210")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E251B0", Offset = "0x4E23DB0", VA = "0x184E251B0")]
		public MutableOverridableListObscuredString(bool MCOLPCPBKJO, List<ObscuredString> ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E25120", Offset = "0x4E23D20", VA = "0x184E25120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E24CC0", Offset = "0x4E238C0", VA = "0x184E24CC0", Slot = "17")]
		public override void EELNFKPNBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E25030", Offset = "0x4E23C30", VA = "0x184E25030", Slot = "20")]
		public override void MCLIHLMJBKH(byte[] JIGLDGJNMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E24D30", Offset = "0x4E23930", VA = "0x184E24D30", Slot = "19")]
		public override void GCMDHGECBGE(AKPAGNBMDEP NELNJPNICAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E24B10", Offset = "0x4E23710", VA = "0x184E24B10", Slot = "18")]
		public override AKPAGNBMDEP ECBBBBDPAJE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OverridableVector3 : global::FHAHOEIMODC<Vector3>, OBNJNLGIFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x932D80", Offset = "0x931980", VA = "0x180932D80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4E26190", Offset = "0x4E24D90", VA = "0x184E26190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x23748E0", Offset = "0x23734E0", VA = "0x1823748E0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E26170", Offset = "0x4E24D70", VA = "0x184E26170")]
		public OverridableVector3(Vector3 ODCJDJDBONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4E260E0", Offset = "0x4E24CE0", VA = "0x184E260E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4E260C0", Offset = "0x4E24CC0", VA = "0x184E260C0")]
		public static OverridableVector3 JKKJHEGKOOJ(Vector3 IFJECFHDAOK)
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
