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
public interface JIFIFAAJHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MMEJOIGNFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object HLDKPBAHNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EKNLBPHIOBB<T> : JIFIFAAJHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PGOCJMFALEP<T> : EKNLBPHIOBB<T>, JIFIFAAJHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MMEJOIGNFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T IOOEMCNJEAH
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
public interface ECGONJLIHDA<T> : PGOCJMFALEP<T>, EKNLBPHIOBB<T>, JIFIFAAJHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OJGLICMPPCC
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
	public struct OverridableInt : EKNLBPHIOBB<int>, JIFIFAAJHAL
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
			[Cpp2IlInjected.Address(RVA = "0xFA8900", Offset = "0xFA7500", VA = "0x180FA8900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7D8B190", Offset = "0x7D89D90", VA = "0x187D8B190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B0F0", Offset = "0x7D89CF0", VA = "0x187D8B0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : EKNLBPHIOBB<string>, JIFIFAAJHAL
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
			[Cpp2IlInjected.Address(RVA = "0xFA8900", Offset = "0xFA7500", VA = "0x180FA8900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B1E0", Offset = "0x7D89DE0", VA = "0x187D8B1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : PGOCJMFALEP<InnerType>, EKNLBPHIOBB<InnerType>, JIFIFAAJHAL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool MMEJOIGNFIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object HLDKPBAHNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CCE0", Offset = "0x2B3B8E0", VA = "0x182B3CCE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55149F0", Offset = "0x55135F0", VA = "0x1855149F0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5514A20", Offset = "0x5513620", VA = "0x185514A20")]
		public MutableOverridableBase(bool AGOMBFAIKEN, [NotNull] InnerType OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x55147E0", Offset = "0x55133E0", VA = "0x1855147E0", Slot = "15")]
		public void FCFGEOLOFMK(EKNLBPHIOBB<InnerType> HOHHCCFFPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x55140C0", Offset = "0x5512CC0", VA = "0x1855140C0", Slot = "16")]
		public void CMICAOGODDE(EKNLBPHIOBB<InnerType> GMNGNCHKEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55148A0", Offset = "0x55134A0", VA = "0x1855148A0", Slot = "17")]
		public virtual void NFHAHJGCAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LAHJGFFFHDG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EMEOLGBIMLO(ProtobufType OGLNCLKDFPC);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JLLLOANKPDG(byte[] OLLLHKLMEEH);
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
			[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAA8AE0", Offset = "0xAA76E0", VA = "0x180AA8AE0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE715B0", Offset = "0xE701B0", VA = "0x180E715B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42D10A0", Offset = "0x42CFCA0", VA = "0x1842D10A0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x470A460", Offset = "0x4709060", VA = "0x18470A460")]
		public SerializedMutableOverridableBase(bool AGOMBFAIKEN, InnerType OOHGFGHCOAJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, EDBFADDKLDE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B020", Offset = "0x7D89C20", VA = "0x187D8B020")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B080", Offset = "0x7D89C80", VA = "0x187D8B080")]
		public MutableOverridableObscuredInt(bool AGOMBFAIKEN, ObscuredInt OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AF50", Offset = "0x7D89B50", VA = "0x187D8AF50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D8ADA0", Offset = "0x7D899A0", VA = "0x187D8ADA0", Slot = "20")]
		public override void JLLLOANKPDG(byte[] OLLLHKLMEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D8ACF0", Offset = "0x7D898F0", VA = "0x187D8ACF0", Slot = "19")]
		public override void EMEOLGBIMLO(EDBFADDKLDE OGLNCLKDFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AE70", Offset = "0x7D89A70", VA = "0x187D8AE70", Slot = "18")]
		public override EDBFADDKLDE LAHJGFFFHDG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, KCFGLMCNPFI>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AC20", Offset = "0x7D89820", VA = "0x187D8AC20")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AC80", Offset = "0x7D89880", VA = "0x187D8AC80")]
		public MutableOverridableObscuredFloat(bool AGOMBFAIKEN, ObscuredFloat OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AB50", Offset = "0x7D89750", VA = "0x187D8AB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A990", Offset = "0x7D89590", VA = "0x187D8A990", Slot = "20")]
		public override void JLLLOANKPDG(byte[] OLLLHKLMEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A8D0", Offset = "0x7D894D0", VA = "0x187D8A8D0", Slot = "19")]
		public override void EMEOLGBIMLO(KCFGLMCNPFI OGLNCLKDFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AA60", Offset = "0x7D89660", VA = "0x187D8AA60", Slot = "18")]
		public override KCFGLMCNPFI LAHJGFFFHDG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, FCNGALPAMHK>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D89B00", Offset = "0x7D88700", VA = "0x187D89B00")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A860", Offset = "0x7D89460", VA = "0x187D8A860")]
		public MutableOverridableObscuredBool(bool AGOMBFAIKEN, ObscuredBool OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A790", Offset = "0x7D89390", VA = "0x187D8A790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A540", Offset = "0x7D89140", VA = "0x187D8A540", Slot = "20")]
		public override void JLLLOANKPDG(byte[] OLLLHKLMEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A480", Offset = "0x7D89080", VA = "0x187D8A480", Slot = "19")]
		public override void EMEOLGBIMLO(FCNGALPAMHK OGLNCLKDFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A610", Offset = "0x7D89210", VA = "0x187D8A610", Slot = "18")]
		public override FCNGALPAMHK LAHJGFFFHDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A700", Offset = "0x7D89300", VA = "0x187D8A700", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, ECGONJLIHDA<ObscuredBool>, PGOCJMFALEP<ObscuredBool>, EKNLBPHIOBB<ObscuredBool>, JIFIFAAJHAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA24660", Offset = "0xA23260", VA = "0x180A24660", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D89B00", Offset = "0x7D88700", VA = "0x187D89B00")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7D89A80", Offset = "0x7D88680", VA = "0x187D89A80")]
		public void FCFGEOLOFMK(MutableOverridableDefaultableObscuredBool GMNGNCHKEBK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, EDBFADDKLDE> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x59FB350", Offset = "0x59F9F50", VA = "0x1859FB350", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x59FB460", Offset = "0x59FA060", VA = "0x1859FB460", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x47034F0", Offset = "0x47020F0", VA = "0x1847034F0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x59FB330", Offset = "0x59F9F30", VA = "0x1859FB330")]
		public SerializedMutableOverridableObscuredEnum(bool AGOMBFAIKEN, TObsEnum OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x59FB1D0", Offset = "0x59F9DD0", VA = "0x1859FB1D0", Slot = "18")]
		public sealed override EDBFADDKLDE LAHJGFFFHDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x59FAFF0", Offset = "0x59F9BF0", VA = "0x1859FAFF0", Slot = "19")]
		public sealed override void EMEOLGBIMLO(EDBFADDKLDE OGLNCLKDFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x59FB0F0", Offset = "0x59F9CF0", VA = "0x1859FB0F0", Slot = "20")]
		public sealed override void JLLLOANKPDG(byte[] OLLLHKLMEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x59FB2C0", Offset = "0x59F9EC0", VA = "0x1859FB2C0", Slot = "17")]
		public sealed override void NFHAHJGCAOH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BOECLBHEDJE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A3B0", Offset = "0x7D88FB0", VA = "0x187D8A3B0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A3F0", Offset = "0x7D88FF0", VA = "0x187D8A3F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A310", Offset = "0x7D88F10", VA = "0x187D8A310")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A2B0", Offset = "0x7D88EB0", VA = "0x187D8A2B0")]
		public MutableOverridableListObscuredString(bool AGOMBFAIKEN, List<ObscuredString> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A210", Offset = "0x7D88E10", VA = "0x187D8A210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A180", Offset = "0x7D88D80", VA = "0x187D8A180", Slot = "17")]
		public override void NFHAHJGCAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7D89ED0", Offset = "0x7D88AD0", VA = "0x187D89ED0", Slot = "20")]
		public override void JLLLOANKPDG(byte[] OLLLHKLMEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D89B70", Offset = "0x7D88770", VA = "0x187D89B70", Slot = "19")]
		public override void EMEOLGBIMLO(BOECLBHEDJE OGLNCLKDFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D89FA0", Offset = "0x7D88BA0", VA = "0x187D89FA0", Slot = "18")]
		public override BOECLBHEDJE LAHJGFFFHDG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : EKNLBPHIOBB<Vector3>, JIFIFAAJHAL
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
			[Cpp2IlInjected.Address(RVA = "0xFA8900", Offset = "0xFA7500", VA = "0x180FA8900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D8B310", Offset = "0x7D89F10", VA = "0x187D8B310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x52748D0", Offset = "0x52734D0", VA = "0x1852748D0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5637600", Offset = "0x5636200", VA = "0x185637600")]
		public OverridableVector3(Vector3 OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C7E0", Offset = "0x5D0B3E0", VA = "0x185D0C7E0")]
		public OverridableVector3(bool AGOMBFAIKEN, Vector3 OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B270", Offset = "0x7D89E70", VA = "0x187D8B270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B250", Offset = "0x7D89E50", VA = "0x187D8B250")]
		public static OverridableVector3 GHOKLFELACP(Vector3 AGKJLFOJIKC)
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
