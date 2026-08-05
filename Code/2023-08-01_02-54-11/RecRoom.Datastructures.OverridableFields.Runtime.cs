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
public interface BIKIIJLJLCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GJDOIPKNLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEGGKBMGAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IABGIFDAECP<T> : BIKIIJLJLCL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IJPFJMNAGLI<T> : IABGIFDAECP<T>, BIKIIJLJLCL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool GJDOIPKNLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T MNHGIJMEOAH
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
public interface LMLHGBDBOLO<T> : IJPFJMNAGLI<T>, IABGIFDAECP<T>, BIKIIJLJLCL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DIKIPEFBFIA
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
	public struct OverridableVector3 : IABGIFDAECP<Vector3>, BIKIIJLJLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB2CFF0", Offset = "0xB2BFF0", VA = "0x180B2CFF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x729BF00", Offset = "0x729AF00", VA = "0x18729BF00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x729BF50", Offset = "0x729AF50", VA = "0x18729BF50", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x729BEE0", Offset = "0x729AEE0", VA = "0x18729BEE0")]
		public OverridableVector3(Vector3 CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x729BE40", Offset = "0x729AE40", VA = "0x18729BE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x729BE10", Offset = "0x729AE10", VA = "0x18729BE10")]
		public static OverridableVector3 DLCNBHCGPLK(Vector3 PCKJKBNEEPE)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : IABGIFDAECP<int>, BIKIIJLJLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB2CFF0", Offset = "0xB2BFF0", VA = "0x180B2CFF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x729BD50", Offset = "0x729AD50", VA = "0x18729BD50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x11BC220", Offset = "0x11BB220", VA = "0x1811BC220", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x729BCB0", Offset = "0x729ACB0", VA = "0x18729BCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : IABGIFDAECP<string>, BIKIIJLJLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB2CFF0", Offset = "0xB2BFF0", VA = "0x180B2CFF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1301750", Offset = "0x1300750", VA = "0x181301750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1301750", Offset = "0x1300750", VA = "0x181301750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x729BDA0", Offset = "0x729ADA0", VA = "0x18729BDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : IJPFJMNAGLI<InnerType>, IABGIFDAECP<InnerType>, BIKIIJLJLCL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool GJDOIPKNLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType MNHGIJMEOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object IEGGKBMGAGK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1E33A80", Offset = "0x1E32A80", VA = "0x181E33A80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2863790", Offset = "0x2862790", VA = "0x182863790")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2863850", Offset = "0x2862850", VA = "0x182863850")]
		public MutableOverridableBase(bool CNBBOOMAPFF, [NotNull] InnerType CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2862FC0", Offset = "0x2861FC0", VA = "0x182862FC0", Slot = "15")]
		public void HLHLBGLIPIP(IABGIFDAECP<InnerType> MHOCGKPHELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28631D0", Offset = "0x28621D0", VA = "0x1828631D0", Slot = "16")]
		public void ICJGLKHKIDI(IABGIFDAECP<InnerType> JONIFABKCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28635D0", Offset = "0x28625D0", VA = "0x1828635D0", Slot = "17")]
		public virtual void OMJIIKCHOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType BEIKKDBGLIO();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void ONFLDOFOIKF(ProtobufType BCIBKJCBEBB);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void BDNJENDIMKM(byte[] JMMKAIMHMMO);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9789D0", Offset = "0x9779D0", VA = "0x1809789D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8400A0", Offset = "0x83F0A0", VA = "0x1808400A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x978A80", Offset = "0x977A80", VA = "0x180978A80", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC17590", Offset = "0xC16590", VA = "0x180C17590", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD87EA0", Offset = "0xD86EA0", VA = "0x180D87EA0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E67B10", Offset = "0x1E66B10", VA = "0x181E67B10")]
		public SerializedMutableOverridableBase(bool CNBBOOMAPFF, InnerType CKMKMNKGMMC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NNAKNDFKNPL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x729BC50", Offset = "0x729AC50", VA = "0x18729BC50")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x729BBE0", Offset = "0x729ABE0", VA = "0x18729BBE0")]
		public MutableOverridableObscuredInt(bool CNBBOOMAPFF, ObscuredInt CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x729BB10", Offset = "0x729AB10", VA = "0x18729BB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x729B890", Offset = "0x729A890", VA = "0x18729B890", Slot = "20")]
		public override void BDNJENDIMKM(byte[] JMMKAIMHMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x729BA40", Offset = "0x729AA40", VA = "0x18729BA40", Slot = "19")]
		public override void ONFLDOFOIKF(NNAKNDFKNPL BCIBKJCBEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x729B940", Offset = "0x729A940", VA = "0x18729B940", Slot = "18")]
		public override NNAKNDFKNPL BEIKKDBGLIO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, MHFKHLICKMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x729B7C0", Offset = "0x729A7C0", VA = "0x18729B7C0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x729B820", Offset = "0x729A820", VA = "0x18729B820")]
		public MutableOverridableObscuredFloat(bool CNBBOOMAPFF, ObscuredFloat CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x729B6F0", Offset = "0x729A6F0", VA = "0x18729B6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x729B450", Offset = "0x729A450", VA = "0x18729B450", Slot = "20")]
		public override void BDNJENDIMKM(byte[] JMMKAIMHMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x729B610", Offset = "0x729A610", VA = "0x18729B610", Slot = "19")]
		public override void ONFLDOFOIKF(MHFKHLICKMJ BCIBKJCBEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x729B500", Offset = "0x729A500", VA = "0x18729B500", Slot = "18")]
		public override MHFKHLICKMJ BEIKKDBGLIO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, MNLBLHLKIEH>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x729A740", Offset = "0x7299740", VA = "0x18729A740")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x729B3E0", Offset = "0x729A3E0", VA = "0x18729B3E0")]
		public MutableOverridableObscuredBool(bool CNBBOOMAPFF, ObscuredBool CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x729B310", Offset = "0x729A310", VA = "0x18729B310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x729B030", Offset = "0x729A030", VA = "0x18729B030", Slot = "20")]
		public override void BDNJENDIMKM(byte[] JMMKAIMHMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x729B1E0", Offset = "0x729A1E0", VA = "0x18729B1E0", Slot = "19")]
		public override void ONFLDOFOIKF(MNLBLHLKIEH BCIBKJCBEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x729B0E0", Offset = "0x729A0E0", VA = "0x18729B0E0", Slot = "18")]
		public override MNLBLHLKIEH BEIKKDBGLIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x729B2C0", Offset = "0x729A2C0", VA = "0x18729B2C0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, LMLHGBDBOLO<ObscuredBool>, IJPFJMNAGLI<ObscuredBool>, IABGIFDAECP<ObscuredBool>, BIKIIJLJLCL
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA4B4B0", Offset = "0xA4A4B0", VA = "0x180A4B4B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4B4C0", Offset = "0xA4A4C0", VA = "0x180A4B4C0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x729A740", Offset = "0x7299740", VA = "0x18729A740")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x729A6C0", Offset = "0x72996C0", VA = "0x18729A6C0")]
		public void HLHLBGLIPIP(MutableOverridableDefaultableObscuredBool JONIFABKCAI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NNAKNDFKNPL> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3784A90", Offset = "0x3783A90", VA = "0x183784A90", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3784B70", Offset = "0x3783B70", VA = "0x183784B70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xEE4360", Offset = "0xEE3360", VA = "0x180EE4360")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3784A60", Offset = "0x3783A60", VA = "0x183784A60")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x33ADA10", Offset = "0x33ACA10", VA = "0x1833ADA10")]
		public SerializedMutableOverridableObscuredEnum(bool CNBBOOMAPFF, TObsEnum CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3784810", Offset = "0x3783810", VA = "0x183784810", Slot = "18")]
		public sealed override NNAKNDFKNPL BEIKKDBGLIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3784940", Offset = "0x3783940", VA = "0x183784940", Slot = "19")]
		public sealed override void ONFLDOFOIKF(NNAKNDFKNPL BCIBKJCBEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3784760", Offset = "0x3783760", VA = "0x183784760", Slot = "20")]
		public sealed override void BDNJENDIMKM(byte[] JMMKAIMHMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x37848E0", Offset = "0x37838E0", VA = "0x1837848E0", Slot = "17")]
		public sealed override void OMJIIKCHOAL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MDMDIMHFIBM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x729AF60", Offset = "0x7299F60", VA = "0x18729AF60", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x729AFA0", Offset = "0x7299FA0", VA = "0x18729AFA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x729AE70", Offset = "0x7299E70", VA = "0x18729AE70")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x729AF00", Offset = "0x7299F00", VA = "0x18729AF00")]
		public MutableOverridableListObscuredString(bool CNBBOOMAPFF, List<ObscuredString> CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x729ADD0", Offset = "0x7299DD0", VA = "0x18729ADD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x729AA40", Offset = "0x7299A40", VA = "0x18729AA40", Slot = "17")]
		public override void OMJIIKCHOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x729A7B0", Offset = "0x72997B0", VA = "0x18729A7B0", Slot = "20")]
		public override void BDNJENDIMKM(byte[] JMMKAIMHMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x729AAB0", Offset = "0x7299AB0", VA = "0x18729AAB0", Slot = "19")]
		public override void ONFLDOFOIKF(MDMDIMHFIBM BCIBKJCBEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x729A860", Offset = "0x7299860", VA = "0x18729A860", Slot = "18")]
		public override MDMDIMHFIBM BEIKKDBGLIO()
		{
			return null;
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
