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
public interface JHAFOPHHEHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CNJHEFKGBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object DFJAICNEOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HMCGPOHHMGL<T> : JHAFOPHHEHD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MCOKOHCMLNP<T> : HMCGPOHHMGL<T>, JHAFOPHHEHD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CNJHEFKGBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ODIKHJJHMMN
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
public interface AFGMPMIKLMH<T> : MCOKOHCMLNP<T>, HMCGPOHHMGL<T>, JHAFOPHHEHD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EMEJCIEGBNF
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
	public struct OverridableVector3 : HMCGPOHHMGL<Vector3>, JHAFOPHHEHD
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
			[Cpp2IlInjected.Address(RVA = "0x191C2D0", Offset = "0x191B0D0", VA = "0x18191C2D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x191C440", Offset = "0x191B240", VA = "0x18191C440", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x191C490", Offset = "0x191B290", VA = "0x18191C490", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x191C420", Offset = "0x191B220", VA = "0x18191C420")]
		public OverridableVector3(Vector3 KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x191C380", Offset = "0x191B180", VA = "0x18191C380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x191C350", Offset = "0x191B150", VA = "0x18191C350")]
		public static OverridableVector3 HAJGNNHEPJI(Vector3 IEGGAJNPOJC)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : HMCGPOHHMGL<int>, JHAFOPHHEHD
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
			[Cpp2IlInjected.Address(RVA = "0x191C2D0", Offset = "0x191B0D0", VA = "0x18191C2D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x191C280", Offset = "0x191B080", VA = "0x18191C280", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE3E350", Offset = "0xE3D150", VA = "0x180E3E350", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x191C1E0", Offset = "0x191AFE0", VA = "0x18191C1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : HMCGPOHHMGL<string>, JHAFOPHHEHD
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
			[Cpp2IlInjected.Address(RVA = "0x191C2D0", Offset = "0x191B0D0", VA = "0x18191C2D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x104D500", Offset = "0x104C300", VA = "0x18104D500", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x104D500", Offset = "0x104C300", VA = "0x18104D500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x191C2E0", Offset = "0x191B0E0", VA = "0x18191C2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : MCOKOHCMLNP<InnerType>, HMCGPOHHMGL<InnerType>, JHAFOPHHEHD where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool CNJHEFKGBAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType ODIKHJJHMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object DFJAICNEOII
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2FF9DB0", Offset = "0x2FF8BB0", VA = "0x182FF9DB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3895560", Offset = "0x3894360", VA = "0x183895560")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3895620", Offset = "0x3894420", VA = "0x183895620")]
		public MutableOverridableBase(bool KHKMODGICCD, [NotNull] InnerType KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3895390", Offset = "0x3894190", VA = "0x183895390", Slot = "15")]
		public void NEIGJFGMEFM(HMCGPOHHMGL<InnerType> OAEOFJEDPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3894D80", Offset = "0x3893B80", VA = "0x183894D80", Slot = "16")]
		public void JJKBJMIFDEF(HMCGPOHHMGL<InnerType> FGBEDAPNDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3894B80", Offset = "0x3893980", VA = "0x183894B80", Slot = "17")]
		public virtual void HKOMOLJGOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MMJMBJLHJFJ();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void IHHMOLCPCGB(ProtobufType EENFLGKPFCF);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JEJIIICHPKH(byte[] PGDLHJFAIGH);
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
			[Cpp2IlInjected.Address(RVA = "0x8041D0", Offset = "0x802FD0", VA = "0x1808041D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8040B0", Offset = "0x802EB0", VA = "0x1808040B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F6290", Offset = "0x7F5090", VA = "0x1807F6290", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x20CBC60", Offset = "0x20CAA60", VA = "0x1820CBC60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E3D0", Offset = "0x1C4D1D0", VA = "0x181C4E3D0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C51A20", Offset = "0x3C50820", VA = "0x183C51A20")]
		public SerializedMutableOverridableBase(bool KHKMODGICCD, InnerType KKLNCEHOHED)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, JCEIDKAEPFP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x191C180", Offset = "0x191AF80", VA = "0x18191C180")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x191C110", Offset = "0x191AF10", VA = "0x18191C110")]
		public MutableOverridableObscuredInt(bool KHKMODGICCD, ObscuredInt KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x191C040", Offset = "0x191AE40", VA = "0x18191C040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x191BE90", Offset = "0x191AC90", VA = "0x18191BE90", Slot = "20")]
		public override void JEJIIICHPKH(byte[] PGDLHJFAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x191BDC0", Offset = "0x191ABC0", VA = "0x18191BDC0", Slot = "19")]
		public override void IHHMOLCPCGB(JCEIDKAEPFP EENFLGKPFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x191BF40", Offset = "0x191AD40", VA = "0x18191BF40", Slot = "18")]
		public override JCEIDKAEPFP MMJMBJLHJFJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, PGMIFELNBHM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x191BCF0", Offset = "0x191AAF0", VA = "0x18191BCF0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x191BD50", Offset = "0x191AB50", VA = "0x18191BD50")]
		public MutableOverridableObscuredFloat(bool KHKMODGICCD, ObscuredFloat KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x191BC20", Offset = "0x191AA20", VA = "0x18191BC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x191BA60", Offset = "0x191A860", VA = "0x18191BA60", Slot = "20")]
		public override void JEJIIICHPKH(byte[] PGDLHJFAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x191B980", Offset = "0x191A780", VA = "0x18191B980", Slot = "19")]
		public override void IHHMOLCPCGB(PGMIFELNBHM EENFLGKPFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x191BB10", Offset = "0x191A910", VA = "0x18191BB10", Slot = "18")]
		public override PGMIFELNBHM MMJMBJLHJFJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, IKGJEKGKIIB>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x191AC80", Offset = "0x1919A80", VA = "0x18191AC80")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x191B910", Offset = "0x191A710", VA = "0x18191B910")]
		public MutableOverridableObscuredBool(bool KHKMODGICCD, ObscuredBool KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x191B840", Offset = "0x191A640", VA = "0x18191B840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x191B650", Offset = "0x191A450", VA = "0x18191B650", Slot = "20")]
		public override void JEJIIICHPKH(byte[] PGDLHJFAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x191B570", Offset = "0x191A370", VA = "0x18191B570", Slot = "19")]
		public override void IHHMOLCPCGB(IKGJEKGKIIB EENFLGKPFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x191B700", Offset = "0x191A500", VA = "0x18191B700", Slot = "18")]
		public override IKGJEKGKIIB MMJMBJLHJFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x191B800", Offset = "0x191A600", VA = "0x18191B800", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, AFGMPMIKLMH<ObscuredBool>, MCOKOHCMLNP<ObscuredBool>, HMCGPOHHMGL<ObscuredBool>, JHAFOPHHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9364C0", Offset = "0x9352C0", VA = "0x1809364C0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9FECB0", Offset = "0x9FDAB0", VA = "0x1809FECB0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x191AC80", Offset = "0x1919A80", VA = "0x18191AC80")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x191AC00", Offset = "0x1919A00", VA = "0x18191AC00")]
		public void NEIGJFGMEFM(MutableOverridableDefaultableObscuredBool FGBEDAPNDEP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, JCEIDKAEPFP> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x43DBEE0", Offset = "0x43DACE0", VA = "0x1843DBEE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x43DBFC0", Offset = "0x43DADC0", VA = "0x1843DBFC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2C53150", Offset = "0x2C51F50", VA = "0x182C53150")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x43DBEB0", Offset = "0x43DACB0", VA = "0x1843DBEB0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9580", Offset = "0x3EC8380", VA = "0x183EC9580")]
		public SerializedMutableOverridableObscuredEnum(bool KHKMODGICCD, TObsEnum KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x43DBDE0", Offset = "0x43DABE0", VA = "0x1843DBDE0", Slot = "18")]
		public sealed override JCEIDKAEPFP MMJMBJLHJFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x43DBC10", Offset = "0x43DAA10", VA = "0x1843DBC10", Slot = "19")]
		public sealed override void IHHMOLCPCGB(JCEIDKAEPFP EENFLGKPFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x43DBD30", Offset = "0x43DAB30", VA = "0x1843DBD30", Slot = "20")]
		public sealed override void JEJIIICHPKH(byte[] PGDLHJFAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x43DBBB0", Offset = "0x43DA9B0", VA = "0x1843DBBB0", Slot = "17")]
		public sealed override void HKOMOLJGOCK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, CDEJMNIKAJI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x191B4A0", Offset = "0x191A2A0", VA = "0x18191B4A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x191B4E0", Offset = "0x191A2E0", VA = "0x18191B4E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x191B3B0", Offset = "0x191A1B0", VA = "0x18191B3B0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x191B440", Offset = "0x191A240", VA = "0x18191B440")]
		public MutableOverridableListObscuredString(bool KHKMODGICCD, List<ObscuredString> KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x191B310", Offset = "0x191A110", VA = "0x18191B310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x191ACF0", Offset = "0x1919AF0", VA = "0x18191ACF0", Slot = "17")]
		public override void HKOMOLJGOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x191B080", Offset = "0x1919E80", VA = "0x18191B080", Slot = "20")]
		public override void JEJIIICHPKH(byte[] PGDLHJFAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x191AD60", Offset = "0x1919B60", VA = "0x18191AD60", Slot = "19")]
		public override void IHHMOLCPCGB(CDEJMNIKAJI EENFLGKPFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x191B130", Offset = "0x1919F30", VA = "0x18191B130", Slot = "18")]
		public override CDEJMNIKAJI MMJMBJLHJFJ()
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
