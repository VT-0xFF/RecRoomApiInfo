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
			[Cpp2IlInjected.Address(RVA = "0xAEAAA0", Offset = "0xAE94A0", VA = "0x180AEAAA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4D74410", Offset = "0x4D72E10", VA = "0x184D74410", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x960AE0", Offset = "0x95F4E0", VA = "0x180960AE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D74390", Offset = "0x4D72D90", VA = "0x184D74390", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xAEAAA0", Offset = "0xAE94A0", VA = "0x180AEAAA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x75BAF0", Offset = "0x75A4F0", VA = "0x18075BAF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x75BAF0", Offset = "0x75A4F0", VA = "0x18075BAF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4D74460", Offset = "0x4D72E60", VA = "0x184D74460", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3269E40", Offset = "0x3268840", VA = "0x183269E40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3269C20", Offset = "0x3268620", VA = "0x183269C20")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3269CD0", Offset = "0x32686D0", VA = "0x183269CD0")]
		public MutableOverridableBase(bool CODMLCLICAH, [NotNull] InnerType HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3269640", Offset = "0x3268040", VA = "0x183269640", Slot = "15")]
		public void LJCEANKPAFE(global::JCCPPIMBINH<InnerType> AFJFCCNILFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3269850", Offset = "0x3268250", VA = "0x183269850", Slot = "16")]
		public void PIHCGNGADIO(global::JCCPPIMBINH<InnerType> KKPJJILPNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x32691B0", Offset = "0x3267BB0", VA = "0x1832691B0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x5A23E0", Offset = "0x5A0DE0", VA = "0x1805A23E0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x64A5B0", Offset = "0x648FB0", VA = "0x18064A5B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x174A5F0", Offset = "0x1748FF0", VA = "0x18174A5F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x218F490", Offset = "0x218DE90", VA = "0x18218F490")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x29CB7C0", Offset = "0x29CA1C0", VA = "0x1829CB7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x326A930", Offset = "0x3269330", VA = "0x18326A930", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x326AA10", Offset = "0x3269410", VA = "0x18326AA10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x218F460", Offset = "0x218DE60", VA = "0x18218F460")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x326A900", Offset = "0x3269300", VA = "0x18326A900")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x326A8D0", Offset = "0x32692D0", VA = "0x18326A8D0")]
		public SerializedMutableOverridableObscuredEnum(bool CODMLCLICAH, TObsEnum HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x326A700", Offset = "0x3269100", VA = "0x18326A700", Slot = "18")]
		public sealed override HGAKNIHFFJG JFOAKIOPGFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x326A7C0", Offset = "0x32691C0", VA = "0x18326A7C0", Slot = "19")]
		public sealed override void NLAFGOOHHPA(HGAKNIHFFJG BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x326A610", Offset = "0x3269010", VA = "0x18326A610", Slot = "20")]
		public sealed override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x326A5B0", Offset = "0x3268FB0", VA = "0x18326A5B0", Slot = "17")]
		public sealed override void HEPELHGAALN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HGAKNIHFFJG>
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D74320", Offset = "0x4D72D20", VA = "0x184D74320")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D742B0", Offset = "0x4D72CB0", VA = "0x184D742B0")]
		public MutableOverridableObscuredInt(bool CODMLCLICAH, ObscuredInt HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D74200", Offset = "0x4D72C00", VA = "0x184D74200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D73F80", Offset = "0x4D72980", VA = "0x184D73F80", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4D74140", Offset = "0x4D72B40", VA = "0x184D74140", Slot = "19")]
		public override void NLAFGOOHHPA(HGAKNIHFFJG BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4D74070", Offset = "0x4D72A70", VA = "0x184D74070", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D73EA0", Offset = "0x4D728A0", VA = "0x184D73EA0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D73F10", Offset = "0x4D72910", VA = "0x184D73F10")]
		public MutableOverridableObscuredFloat(bool CODMLCLICAH, ObscuredFloat HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D73DF0", Offset = "0x4D727F0", VA = "0x184D73DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D73B50", Offset = "0x4D72550", VA = "0x184D73B50", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D73D20", Offset = "0x4D72720", VA = "0x184D73D20", Slot = "19")]
		public override void NLAFGOOHHPA(DHOJKJFMFMC BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4D73C40", Offset = "0x4D72640", VA = "0x184D73C40", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D73A80", Offset = "0x4D72480", VA = "0x184D73A80")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4D73AE0", Offset = "0x4D724E0", VA = "0x184D73AE0")]
		public MutableOverridableObscuredBool(bool CODMLCLICAH, ObscuredBool HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4D739D0", Offset = "0x4D723D0", VA = "0x184D739D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D73740", Offset = "0x4D72140", VA = "0x184D73740", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D73910", Offset = "0x4D72310", VA = "0x184D73910", Slot = "19")]
		public override void NLAFGOOHHPA(LFGNJEJPAHL BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D73830", Offset = "0x4D72230", VA = "0x184D73830", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D73690", Offset = "0x4D72090", VA = "0x184D73690", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4D736D0", Offset = "0x4D720D0", VA = "0x184D736D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D73610", Offset = "0x4D72010", VA = "0x184D73610")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D735B0", Offset = "0x4D71FB0", VA = "0x184D735B0")]
		public MutableOverridableListObscuredString(bool CODMLCLICAH, List<ObscuredString> HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D73520", Offset = "0x4D71F20", VA = "0x184D73520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D72F10", Offset = "0x4D71910", VA = "0x184D72F10", Slot = "17")]
		public override void HEPELHGAALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D72F80", Offset = "0x4D71980", VA = "0x184D72F80", Slot = "20")]
		public override void JAMOFFICMHA(byte[] LPEGGJLMBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D73220", Offset = "0x4D71C20", VA = "0x184D73220", Slot = "19")]
		public override void NLAFGOOHHPA(EPPPGBJKFLE BIDDBIBMJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D73070", Offset = "0x4D71A70", VA = "0x184D73070", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xAEAAA0", Offset = "0xAE94A0", VA = "0x180AEAAA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4D74590", Offset = "0x4D72F90", VA = "0x184D74590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x124CA80", Offset = "0x124B480", VA = "0x18124CA80", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D74570", Offset = "0x4D72F70", VA = "0x184D74570")]
		public OverridableVector3(Vector3 HPIAFNBPEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4D744E0", Offset = "0x4D72EE0", VA = "0x184D744E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D744C0", Offset = "0x4D72EC0", VA = "0x184D744C0")]
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
