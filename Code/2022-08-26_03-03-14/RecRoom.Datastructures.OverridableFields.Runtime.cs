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
public interface JLCHMANPKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JMKGICHBPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object GMJHNNKIIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LKBLLEJKPAB<T> : JLCHMANPKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ONGHMHAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DGAJIDEGCLN<T> : global::LKBLLEJKPAB<T>, JLCHMANPKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JMKGICHBPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ONGHMHAEIAB
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
public interface MJNPFPDBDOA<T> : global::DGAJIDEGCLN<T>, global::LKBLLEJKPAB<T>, JLCHMANPKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KDJGLIEPOOF
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
	public struct OverridableInt : global::LKBLLEJKPAB<int>, JLCHMANPKCG
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
			[Cpp2IlInjected.Address(RVA = "0xCE7070", Offset = "0xCE5C70", VA = "0x180CE7070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5893860", Offset = "0x5892460", VA = "0x185893860", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58937E0", Offset = "0x58923E0", VA = "0x1858937E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::LKBLLEJKPAB<string>, JLCHMANPKCG
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
			[Cpp2IlInjected.Address(RVA = "0xCE7070", Offset = "0xCE5C70", VA = "0x180CE7070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x925B10", Offset = "0x924710", VA = "0x180925B10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x925B10", Offset = "0x924710", VA = "0x180925B10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x58938B0", Offset = "0x58924B0", VA = "0x1858938B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::DGAJIDEGCLN<InnerType>, global::LKBLLEJKPAB<InnerType>, JLCHMANPKCG where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JMKGICHBPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ONGHMHAEIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object GMJHNNKIIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF450", Offset = "0x2BBE050", VA = "0x182BBF450", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF230", Offset = "0x2BBDE30", VA = "0x182BBF230")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF2E0", Offset = "0x2BBDEE0", VA = "0x182BBF2E0")]
		public MutableOverridableBase(bool DPABGDENFCH, [NotNull] InnerType KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BBED20", Offset = "0x2BBD920", VA = "0x182BBED20", Slot = "15")]
		public void NBCCDDINJLG(global::LKBLLEJKPAB<InnerType> NFJGKGJHPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE840", Offset = "0x2BBD440", VA = "0x182BBE840", Slot = "16")]
		public void LCAMBDBAHHD(global::LKBLLEJKPAB<InnerType> NPKIIGGBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEB90", Offset = "0x2BBD790", VA = "0x182BBEB90", Slot = "17")]
		public virtual void MFLCPIEJCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType GPEGCEEEHDP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void GJPGHABHLOL(ProtobufType EHPCBBBCICC);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void KJLHLGHGFEI(byte[] PLHKIBNCNCK);
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
			[Cpp2IlInjected.Address(RVA = "0x6177B0", Offset = "0x6163B0", VA = "0x1806177B0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x66E8C0", Offset = "0x66D4C0", VA = "0x18066E8C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1076670", Offset = "0x1075270", VA = "0x181076670", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5B80", Offset = "0x1FC4780", VA = "0x181FC5B80")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1800", Offset = "0x2BC0400", VA = "0x182BC1800")]
		public SerializedMutableOverridableBase(bool DPABGDENFCH, InnerType KGJOJGIPNPH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, JFEAEGADMOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5893770", Offset = "0x5892370", VA = "0x185893770")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5893700", Offset = "0x5892300", VA = "0x185893700")]
		public MutableOverridableObscuredInt(bool DPABGDENFCH, ObscuredInt KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5893650", Offset = "0x5892250", VA = "0x185893650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5893560", Offset = "0x5892160", VA = "0x185893560", Slot = "20")]
		public override void KJLHLGHGFEI(byte[] PLHKIBNCNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x58933D0", Offset = "0x5891FD0", VA = "0x1858933D0", Slot = "19")]
		public override void GJPGHABHLOL(JFEAEGADMOJ EHPCBBBCICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5893490", Offset = "0x5892090", VA = "0x185893490", Slot = "18")]
		public override JFEAEGADMOJ GPEGCEEEHDP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DGGMCNFALHD>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58932F0", Offset = "0x5891EF0", VA = "0x1858932F0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5893360", Offset = "0x5891F60", VA = "0x185893360")]
		public MutableOverridableObscuredFloat(bool DPABGDENFCH, ObscuredFloat KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5893240", Offset = "0x5891E40", VA = "0x185893240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5893150", Offset = "0x5891D50", VA = "0x185893150", Slot = "20")]
		public override void KJLHLGHGFEI(byte[] PLHKIBNCNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5892FA0", Offset = "0x5891BA0", VA = "0x185892FA0", Slot = "19")]
		public override void GJPGHABHLOL(DGGMCNFALHD EHPCBBBCICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5893070", Offset = "0x5891C70", VA = "0x185893070", Slot = "18")]
		public override DGGMCNFALHD GPEGCEEEHDP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, OPONKCAGFHN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5892360", Offset = "0x5890F60", VA = "0x185892360")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5892F30", Offset = "0x5891B30", VA = "0x185892F30")]
		public MutableOverridableObscuredBool(bool DPABGDENFCH, ObscuredBool KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5892E80", Offset = "0x5891A80", VA = "0x185892E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5892D90", Offset = "0x5891990", VA = "0x185892D90", Slot = "20")]
		public override void KJLHLGHGFEI(byte[] PLHKIBNCNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5892BF0", Offset = "0x58917F0", VA = "0x185892BF0", Slot = "19")]
		public override void GJPGHABHLOL(OPONKCAGFHN EHPCBBBCICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5892CB0", Offset = "0x58918B0", VA = "0x185892CB0", Slot = "18")]
		public override OPONKCAGFHN GPEGCEEEHDP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::MJNPFPDBDOA<ObscuredBool>, global::DGAJIDEGCLN<ObscuredBool>, global::LKBLLEJKPAB<ObscuredBool>, JLCHMANPKCG
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5EC190", Offset = "0x5EAD90", VA = "0x1805EC190", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x747180", Offset = "0x745D80", VA = "0x180747180", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5892360", Offset = "0x5890F60", VA = "0x185892360")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x58922E0", Offset = "0x5890EE0", VA = "0x1858922E0")]
		public void NBCCDDINJLG(MutableOverridableDefaultableObscuredBool NPKIIGGBCCI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, JFEAEGADMOJ> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1C50", Offset = "0x2BC0850", VA = "0x182BC1C50", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1D30", Offset = "0x2BC0930", VA = "0x182BC1D30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCFE00", Offset = "0x1FCEA00", VA = "0x181FCFE00")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1C20", Offset = "0x2BC0820", VA = "0x182BC1C20")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1BF0", Offset = "0x2BC07F0", VA = "0x182BC1BF0")]
		public SerializedMutableOverridableObscuredEnum(bool DPABGDENFCH, TObsEnum KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC19E0", Offset = "0x2BC05E0", VA = "0x182BC19E0", Slot = "18")]
		public sealed override JFEAEGADMOJ GPEGCEEEHDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BC18D0", Offset = "0x2BC04D0", VA = "0x182BC18D0", Slot = "19")]
		public sealed override void GJPGHABHLOL(JFEAEGADMOJ EHPCBBBCICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1AA0", Offset = "0x2BC06A0", VA = "0x182BC1AA0", Slot = "20")]
		public sealed override void KJLHLGHGFEI(byte[] PLHKIBNCNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B90", Offset = "0x2BC0790", VA = "0x182BC1B90", Slot = "17")]
		public sealed override void MFLCPIEJCKP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MKGACNHKPHO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5892B40", Offset = "0x5891740", VA = "0x185892B40", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5892B80", Offset = "0x5891780", VA = "0x185892B80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5892AC0", Offset = "0x58916C0", VA = "0x185892AC0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5892A60", Offset = "0x5891660", VA = "0x185892A60")]
		public MutableOverridableListObscuredString(bool DPABGDENFCH, List<ObscuredString> KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x58929D0", Offset = "0x58915D0", VA = "0x1858929D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5892960", Offset = "0x5891560", VA = "0x185892960", Slot = "17")]
		public override void MFLCPIEJCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5892870", Offset = "0x5891470", VA = "0x185892870", Slot = "20")]
		public override void KJLHLGHGFEI(byte[] PLHKIBNCNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x58923C0", Offset = "0x5890FC0", VA = "0x1858923C0", Slot = "19")]
		public override void GJPGHABHLOL(MKGACNHKPHO EHPCBBBCICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x58926C0", Offset = "0x58912C0", VA = "0x1858926C0", Slot = "18")]
		public override MKGACNHKPHO GPEGCEEEHDP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::LKBLLEJKPAB<Vector3>, JLCHMANPKCG
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
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7070", Offset = "0xCE5C70", VA = "0x180CE7070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x58939E0", Offset = "0x58925E0", VA = "0x1858939E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2A970F0", Offset = "0x2A95CF0", VA = "0x182A970F0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x58939C0", Offset = "0x58925C0", VA = "0x1858939C0")]
		public OverridableVector3(Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5893930", Offset = "0x5892530", VA = "0x185893930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5893910", Offset = "0x5892510", VA = "0x185893910")]
		public static OverridableVector3 GOPIOOMOEDD(Vector3 OOIECLPAPEE)
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
