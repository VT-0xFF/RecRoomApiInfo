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
public interface GDPDCKALPFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EHIHEFGIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CPEICFGNMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NAEAGFIEANK<T> : GDPDCKALPFC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GKJBKPAGAED<T> : NAEAGFIEANK<T>, GDPDCKALPFC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool EHIHEFGIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T APFNDOMNAPN
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
public interface HFLCNCGBAKL<T> : GKJBKPAGAED<T>, NAEAGFIEANK<T>, GDPDCKALPFC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CNEEPOOPEGN
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
	public struct OverridableInt : NAEAGFIEANK<int>, GDPDCKALPFC
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
			[Cpp2IlInjected.Address(RVA = "0xEC11B0", Offset = "0xEC05B0", VA = "0x180EC11B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0B10", Offset = "0x7ABFF10", VA = "0x187AC0B10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0A70", Offset = "0x7ABFE70", VA = "0x187AC0A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : NAEAGFIEANK<string>, GDPDCKALPFC
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
			[Cpp2IlInjected.Address(RVA = "0xEC11B0", Offset = "0xEC05B0", VA = "0x180EC11B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD5AA00", Offset = "0xD59E00", VA = "0x180D5AA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD5AA00", Offset = "0xD59E00", VA = "0x180D5AA00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0B60", Offset = "0x7ABFF60", VA = "0x187AC0B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GKJBKPAGAED<InnerType>, NAEAGFIEANK<InnerType>, GDPDCKALPFC where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool EHIHEFGIEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CPEICFGNMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28DDBB0", Offset = "0x28DCFB0", VA = "0x1828DDBB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51518C0", Offset = "0x5150CC0", VA = "0x1851518C0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51518F0", Offset = "0x5150CF0", VA = "0x1851518F0")]
		public MutableOverridableBase(bool DMEPAPCCCNF, [NotNull] InnerType OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x51515D0", Offset = "0x51509D0", VA = "0x1851515D0", Slot = "15")]
		public void DGJPJOGONDA(NAEAGFIEANK<InnerType> JOAJJJIEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5151210", Offset = "0x5150610", VA = "0x185151210", Slot = "16")]
		public void BIOKGNHBAIE(NAEAGFIEANK<InnerType> DMMBOHMLHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5151880", Offset = "0x5150C80", VA = "0x185151880", Slot = "17")]
		public virtual void ICMDEPLACPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType ONPFCMIPIGJ();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void KNANGBDNCJF(ProtobufType GJBJAJEDGJF);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void LKEBFDHGDKM(byte[] PKAMABIMNCG);
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
			[Cpp2IlInjected.Address(RVA = "0xC461D0", Offset = "0xC455D0", VA = "0x180C461D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD99FA0", Offset = "0xD993A0", VA = "0x180D99FA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x434E6A0", Offset = "0x434DAA0", VA = "0x18434E6A0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5198510", Offset = "0x5197910", VA = "0x185198510")]
		public SerializedMutableOverridableBase(bool DMEPAPCCCNF, InnerType OOEMJLHLIHJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NFDONCJMDCC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7AC09A0", Offset = "0x7ABFDA0", VA = "0x187AC09A0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0A00", Offset = "0x7ABFE00", VA = "0x187AC0A00")]
		public MutableOverridableObscuredInt(bool DMEPAPCCCNF, ObscuredInt OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AC08D0", Offset = "0x7ABFCD0", VA = "0x187AC08D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0710", Offset = "0x7ABFB10", VA = "0x187AC0710", Slot = "20")]
		public override void LKEBFDHGDKM(byte[] PKAMABIMNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0660", Offset = "0x7ABFA60", VA = "0x187AC0660", Slot = "19")]
		public override void KNANGBDNCJF(NFDONCJMDCC GJBJAJEDGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AC07F0", Offset = "0x7ABFBF0", VA = "0x187AC07F0", Slot = "18")]
		public override NFDONCJMDCC ONPFCMIPIGJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, GCBAPAEMAIO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0590", Offset = "0x7ABF990", VA = "0x187AC0590")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC05F0", Offset = "0x7ABF9F0", VA = "0x187AC05F0")]
		public MutableOverridableObscuredFloat(bool DMEPAPCCCNF, ObscuredFloat OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC04C0", Offset = "0x7ABF8C0", VA = "0x187AC04C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC02F0", Offset = "0x7ABF6F0", VA = "0x187AC02F0", Slot = "20")]
		public override void LKEBFDHGDKM(byte[] PKAMABIMNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0230", Offset = "0x7ABF630", VA = "0x187AC0230", Slot = "19")]
		public override void KNANGBDNCJF(GCBAPAEMAIO GJBJAJEDGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC03D0", Offset = "0x7ABF7D0", VA = "0x187AC03D0", Slot = "18")]
		public override GCBAPAEMAIO ONPFCMIPIGJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, EDGIDGGNDJC>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF430", Offset = "0x7ABE830", VA = "0x187ABF430")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AC01C0", Offset = "0x7ABF5C0", VA = "0x187AC01C0")]
		public MutableOverridableObscuredBool(bool DMEPAPCCCNF, ObscuredBool OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7AC00F0", Offset = "0x7ABF4F0", VA = "0x187AC00F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFE90", Offset = "0x7ABF290", VA = "0x187ABFE90", Slot = "20")]
		public override void LKEBFDHGDKM(byte[] PKAMABIMNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFDD0", Offset = "0x7ABF1D0", VA = "0x187ABFDD0", Slot = "19")]
		public override void KNANGBDNCJF(EDGIDGGNDJC GJBJAJEDGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFF70", Offset = "0x7ABF370", VA = "0x187ABFF70", Slot = "18")]
		public override EDGIDGGNDJC ONPFCMIPIGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0060", Offset = "0x7ABF460", VA = "0x187AC0060", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, HFLCNCGBAKL<ObscuredBool>, GKJBKPAGAED<ObscuredBool>, NAEAGFIEANK<ObscuredBool>, GDPDCKALPFC
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9C91C0", Offset = "0x9C85C0", VA = "0x1809C91C0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9C9250", Offset = "0x9C8650", VA = "0x1809C9250", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF430", Offset = "0x7ABE830", VA = "0x187ABF430")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF3B0", Offset = "0x7ABE7B0", VA = "0x187ABF3B0")]
		public void DGJPJOGONDA(MutableOverridableDefaultableObscuredBool DMMBOHMLHLF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NFDONCJMDCC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x56DFE80", Offset = "0x56DF280", VA = "0x1856DFE80", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x56E0020", Offset = "0x56DF420", VA = "0x1856E0020", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x497C050", Offset = "0x497B450", VA = "0x18497C050")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x56DFE40", Offset = "0x56DF240", VA = "0x1856DFE40")]
		public SerializedMutableOverridableObscuredEnum(bool DMEPAPCCCNF, TObsEnum OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x56DFD50", Offset = "0x56DF150", VA = "0x1856DFD50", Slot = "18")]
		public sealed override NFDONCJMDCC ONPFCMIPIGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x56DFB70", Offset = "0x56DEF70", VA = "0x1856DFB70", Slot = "19")]
		public sealed override void KNANGBDNCJF(NFDONCJMDCC GJBJAJEDGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x56DFC70", Offset = "0x56DF070", VA = "0x1856DFC70", Slot = "20")]
		public sealed override void LKEBFDHGDKM(byte[] PKAMABIMNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x56DFAF0", Offset = "0x56DEEF0", VA = "0x1856DFAF0", Slot = "17")]
		public sealed override void ICMDEPLACPK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, PFNPGNICFHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7ABFD00", Offset = "0x7ABF100", VA = "0x187ABFD00", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7ABFD40", Offset = "0x7ABF140", VA = "0x187ABFD40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFC60", Offset = "0x7ABF060", VA = "0x187ABFC60")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFC00", Offset = "0x7ABF000", VA = "0x187ABFC00")]
		public MutableOverridableListObscuredString(bool DMEPAPCCCNF, List<ObscuredString> OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFB60", Offset = "0x7ABEF60", VA = "0x187ABFB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF4A0", Offset = "0x7ABE8A0", VA = "0x187ABF4A0", Slot = "17")]
		public override void ICMDEPLACPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF8A0", Offset = "0x7ABECA0", VA = "0x187ABF8A0", Slot = "20")]
		public override void LKEBFDHGDKM(byte[] PKAMABIMNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF530", Offset = "0x7ABE930", VA = "0x187ABF530", Slot = "19")]
		public override void KNANGBDNCJF(PFNPGNICFHM GJBJAJEDGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF980", Offset = "0x7ABED80", VA = "0x187ABF980", Slot = "18")]
		public override PFNPGNICFHM ONPFCMIPIGJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : NAEAGFIEANK<Vector3>, GDPDCKALPFC
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
			[Cpp2IlInjected.Address(RVA = "0xEC11B0", Offset = "0xEC05B0", VA = "0x180EC11B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0C90", Offset = "0x7AC0090", VA = "0x187AC0C90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4E81B00", Offset = "0x4E80F00", VA = "0x184E81B00", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5301960", Offset = "0x5300D60", VA = "0x185301960")]
		public OverridableVector3(Vector3 OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x59F6730", Offset = "0x59F5B30", VA = "0x1859F6730")]
		public OverridableVector3(bool DMEPAPCCCNF, Vector3 OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0BF0", Offset = "0x7ABFFF0", VA = "0x187AC0BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0BD0", Offset = "0x7ABFFD0", VA = "0x187AC0BD0")]
		public static OverridableVector3 HIHFKEJHDAH(Vector3 DBALGCNBEDK)
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
