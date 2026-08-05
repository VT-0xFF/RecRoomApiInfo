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
public interface MJGFCBGKLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GKEPMGCDFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IKEFHPCNGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JCCPPIMBINH<T> : MJGFCBGKLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NOECBBBDEMO<T> : global::JCCPPIMBINH<T>, MJGFCBGKLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool GKEPMGCDFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T CKLNJLLILCL
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
	public struct OverridableInt : global::JCCPPIMBINH<int>, MJGFCBGKLFL
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
			[Cpp2IlInjected.Address(RVA = "0x707250", Offset = "0x705C50", VA = "0x180707250", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1912C50", Offset = "0x1911650", VA = "0x181912C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C150", Offset = "0xA9AB50", VA = "0x180A9C150", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1912BD0", Offset = "0x19115D0", VA = "0x181912BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableString : global::JCCPPIMBINH<string>, MJGFCBGKLFL
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
			[Cpp2IlInjected.Address(RVA = "0x707250", Offset = "0x705C50", VA = "0x180707250", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x764B00", Offset = "0x763500", VA = "0x180764B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x764B00", Offset = "0x763500", VA = "0x180764B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1912CA0", Offset = "0x19116A0", VA = "0x181912CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::NOECBBBDEMO<InnerType>, global::JCCPPIMBINH<InnerType>, MJGFCBGKLFL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract bool GKEPMGCDFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract InnerType CKLNJLLILCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object IKEFHPCNGJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3203720", Offset = "0x3202120", VA = "0x183203720", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3203500", Offset = "0x3201F00", VA = "0x183203500")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x32035B0", Offset = "0x3201FB0", VA = "0x1832035B0")]
		public MutableOverridableBase(bool CODMLCLICAH, [NotNull] InnerType HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3202F20", Offset = "0x3201920", VA = "0x183202F20", Slot = "15")]
		public void LJCEANKPAFE(global::JCCPPIMBINH<InnerType> AFJFCCNILFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3203130", Offset = "0x3201B30", VA = "0x183203130", Slot = "16")]
		public void PIHCGNGADIO(global::JCCPPIMBINH<InnerType> KKPJJILPNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3202A90", Offset = "0x3201490", VA = "0x183202A90", Slot = "17")]
		public virtual void HEPELHGAALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType JFOAKIOPGFC();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void NLAFGOOHHPA(ProtobufType BIDDBIBMJAJ);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JAMOFFICMHA(byte[] LPEGGJLMBEL);
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
			[Cpp2IlInjected.Address(RVA = "0x5B33E0", Offset = "0x5B1DE0", VA = "0x1805B33E0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x698350", Offset = "0x696D50", VA = "0x180698350", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1D3CA80", Offset = "0x1D3B480", VA = "0x181D3CA80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x274BD10", Offset = "0x274A710", VA = "0x18274BD10")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB740", Offset = "0x2CAA140", VA = "0x182CAB740")]
		public SerializedMutableOverridableBase(bool CODMLCLICAH, InnerType HPIAFNBPEPC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HGAKNIHFFJG> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x320D390", Offset = "0x320BD90", VA = "0x18320D390", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x320D470", Offset = "0x320BE70", VA = "0x18320D470", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2752280", Offset = "0x2750C80", VA = "0x182752280")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x320D360", Offset = "0x320BD60", VA = "0x18320D360")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x320D330", Offset = "0x320BD30", VA = "0x18320D330")]
		public SerializedMutableOverridableObscuredEnum(bool CODMLCLICAH, TObsEnum HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x320D160", Offset = "0x320BB60", VA = "0x18320D160", Slot = "18")]
		public sealed override HGAKNIHFFJG JFOAKIOPGFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x320D220", Offset = "0x320BC20", VA = "0x18320D220", Slot = "19")]
		public sealed override void NLAFGOOHHPA(HGAKNIHFFJG BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x320D070", Offset = "0x320BA70", VA = "0x18320D070", Slot = "20")]
		public sealed override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x320D010", Offset = "0x320BA10", VA = "0x18320D010", Slot = "17")]
		public sealed override void HEPELHGAALN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HGAKNIHFFJG>
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1912B60", Offset = "0x1911560", VA = "0x181912B60")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1912AF0", Offset = "0x19114F0", VA = "0x181912AF0")]
		public MutableOverridableObscuredInt(bool CODMLCLICAH, ObscuredInt HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1912A40", Offset = "0x1911440", VA = "0x181912A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x19127C0", Offset = "0x19111C0", VA = "0x1819127C0", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1912980", Offset = "0x1911380", VA = "0x181912980", Slot = "19")]
		public override void NLAFGOOHHPA(HGAKNIHFFJG BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x19128B0", Offset = "0x19112B0", VA = "0x1819128B0", Slot = "18")]
		public override HGAKNIHFFJG JFOAKIOPGFC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DHOJKJFMFMC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19126E0", Offset = "0x19110E0", VA = "0x1819126E0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1912750", Offset = "0x1911150", VA = "0x181912750")]
		public MutableOverridableObscuredFloat(bool CODMLCLICAH, ObscuredFloat HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1912630", Offset = "0x1911030", VA = "0x181912630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1912390", Offset = "0x1910D90", VA = "0x181912390", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1912560", Offset = "0x1910F60", VA = "0x181912560", Slot = "19")]
		public override void NLAFGOOHHPA(DHOJKJFMFMC BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1912480", Offset = "0x1910E80", VA = "0x181912480", Slot = "18")]
		public override DHOJKJFMFMC JFOAKIOPGFC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LFGNJEJPAHL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x19122C0", Offset = "0x1910CC0", VA = "0x1819122C0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1912320", Offset = "0x1910D20", VA = "0x181912320")]
		public MutableOverridableObscuredBool(bool CODMLCLICAH, ObscuredBool HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1912210", Offset = "0x1910C10", VA = "0x181912210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1911F80", Offset = "0x1910980", VA = "0x181911F80", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1912150", Offset = "0x1910B50", VA = "0x181912150", Slot = "19")]
		public override void NLAFGOOHHPA(LFGNJEJPAHL BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1912070", Offset = "0x1910A70", VA = "0x181912070", Slot = "18")]
		public override LFGNJEJPAHL JFOAKIOPGFC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, EPPPGBJKFLE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1911ED0", Offset = "0x19108D0", VA = "0x181911ED0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1911F10", Offset = "0x1910910", VA = "0x181911F10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1911E50", Offset = "0x1910850", VA = "0x181911E50")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1911DF0", Offset = "0x19107F0", VA = "0x181911DF0")]
		public MutableOverridableListObscuredString(bool CODMLCLICAH, List<ObscuredString> HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1911D60", Offset = "0x1910760", VA = "0x181911D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1911750", Offset = "0x1910150", VA = "0x181911750", Slot = "17")]
		public override void HEPELHGAALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19117C0", Offset = "0x19101C0", VA = "0x1819117C0", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1911A60", Offset = "0x1910460", VA = "0x181911A60", Slot = "19")]
		public override void NLAFGOOHHPA(EPPPGBJKFLE BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x19118B0", Offset = "0x19102B0", VA = "0x1819118B0", Slot = "18")]
		public override EPPPGBJKFLE JFOAKIOPGFC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OverridableVector3 : global::JCCPPIMBINH<Vector3>, MJGFCBGKLFL
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
			[Cpp2IlInjected.Address(RVA = "0x707250", Offset = "0x705C50", VA = "0x180707250", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1912DD0", Offset = "0x19117D0", VA = "0x181912DD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x17B74D0", Offset = "0x17B5ED0", VA = "0x1817B74D0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1912DB0", Offset = "0x19117B0", VA = "0x181912DB0")]
		public OverridableVector3(Vector3 HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1912D20", Offset = "0x1911720", VA = "0x181912D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1912D00", Offset = "0x1911700", VA = "0x181912D00")]
		public static OverridableVector3 EDEIDOGAGHI(Vector3 LFNNMJBIDMK)
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
