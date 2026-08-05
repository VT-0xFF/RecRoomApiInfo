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
public interface JBEANFFLJAO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJPMCMGLKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CFONLIFLALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MIIKGEDJHGP<T> : JBEANFFLJAO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KKGPDKJIHOB<T> : MIIKGEDJHGP<T>, JBEANFFLJAO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool PJPMCMGLKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ABKPALEDJBA
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
public interface HHLAPEBAPPO<T> : KKGPDKJIHOB<T>, MIIKGEDJHGP<T>, JBEANFFLJAO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AFPHHBHONCK
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
	public struct OverridableInt : MIIKGEDJHGP<int>, JBEANFFLJAO
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
			[Cpp2IlInjected.Address(RVA = "0xE81DE0", Offset = "0xE807E0", VA = "0x180E81DE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x78CE420", Offset = "0x78CCE20", VA = "0x1878CE420", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78CE380", Offset = "0x78CCD80", VA = "0x1878CE380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : MIIKGEDJHGP<string>, JBEANFFLJAO
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
			[Cpp2IlInjected.Address(RVA = "0xE81DE0", Offset = "0xE807E0", VA = "0x180E81DE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78CE470", Offset = "0x78CCE70", VA = "0x1878CE470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : KKGPDKJIHOB<InnerType>, MIIKGEDJHGP<InnerType>, JBEANFFLJAO where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool PJPMCMGLKCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CFONLIFLALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2868410", Offset = "0x2866E10", VA = "0x182868410", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51841E0", Offset = "0x5182BE0", VA = "0x1851841E0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5184210", Offset = "0x5182C10", VA = "0x185184210")]
		public MutableOverridableBase(bool IPHIFICKJHD, [NotNull] InnerType PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5183FD0", Offset = "0x51829D0", VA = "0x185183FD0", Slot = "15")]
		public void MGLGJDFFIIP(MIIKGEDJHGP<InnerType> FGHNEGLCMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51837C0", Offset = "0x51821C0", VA = "0x1851837C0", Slot = "16")]
		public void BHGIPDHFJMP(MIIKGEDJHGP<InnerType> OLKLGHOAKNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5184150", Offset = "0x5182B50", VA = "0x185184150", Slot = "17")]
		public virtual void OPIOKFDHGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType EDPCJDELACB();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void MAAGMMPIAKJ(ProtobufType NMADNLDLIAJ);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void KAIAKPLEOIP(byte[] MFNPKGKMFBJ);
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
			[Cpp2IlInjected.Address(RVA = "0xBFFB90", Offset = "0xBFE590", VA = "0x180BFFB90", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBFF920", Offset = "0xBFE320", VA = "0x180BFF920", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD57260", Offset = "0xD55C60", VA = "0x180D57260", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x431C530", Offset = "0x431AF30", VA = "0x18431C530")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51BC1B0", Offset = "0x51BABB0", VA = "0x1851BC1B0")]
		public SerializedMutableOverridableBase(bool IPHIFICKJHD, InnerType PPJFMHBDGNA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BPPOKGNCFHM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x78CE2B0", Offset = "0x78CCCB0", VA = "0x1878CE2B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x78CE310", Offset = "0x78CCD10", VA = "0x1878CE310")]
		public MutableOverridableObscuredInt(bool IPHIFICKJHD, ObscuredInt PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78CE1E0", Offset = "0x78CCBE0", VA = "0x1878CE1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78CE060", Offset = "0x78CCA60", VA = "0x1878CE060", Slot = "20")]
		public override void KAIAKPLEOIP(byte[] MFNPKGKMFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78CE130", Offset = "0x78CCB30", VA = "0x1878CE130", Slot = "19")]
		public override void MAAGMMPIAKJ(BPPOKGNCFHM NMADNLDLIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78CDF80", Offset = "0x78CC980", VA = "0x1878CDF80", Slot = "18")]
		public override BPPOKGNCFHM EDPCJDELACB()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, EIFNHECFGJI>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x78CDEB0", Offset = "0x78CC8B0", VA = "0x1878CDEB0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78CDF10", Offset = "0x78CC910", VA = "0x1878CDF10")]
		public MutableOverridableObscuredFloat(bool IPHIFICKJHD, ObscuredFloat PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78CDDE0", Offset = "0x78CC7E0", VA = "0x1878CDDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78CDC50", Offset = "0x78CC650", VA = "0x1878CDC50", Slot = "20")]
		public override void KAIAKPLEOIP(byte[] MFNPKGKMFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78CDD20", Offset = "0x78CC720", VA = "0x1878CDD20", Slot = "19")]
		public override void MAAGMMPIAKJ(EIFNHECFGJI NMADNLDLIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78CDB60", Offset = "0x78CC560", VA = "0x1878CDB60", Slot = "18")]
		public override EIFNHECFGJI EDPCJDELACB()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, AOPCPAMFOHH>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78CCD90", Offset = "0x78CB790", VA = "0x1878CCD90")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78CDAF0", Offset = "0x78CC4F0", VA = "0x1878CDAF0")]
		public MutableOverridableObscuredBool(bool IPHIFICKJHD, ObscuredBool PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78CDA20", Offset = "0x78CC420", VA = "0x1878CDA20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78CD800", Offset = "0x78CC200", VA = "0x1878CD800", Slot = "20")]
		public override void KAIAKPLEOIP(byte[] MFNPKGKMFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78CD8D0", Offset = "0x78CC2D0", VA = "0x1878CD8D0", Slot = "19")]
		public override void MAAGMMPIAKJ(AOPCPAMFOHH NMADNLDLIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78CD710", Offset = "0x78CC110", VA = "0x1878CD710", Slot = "18")]
		public override AOPCPAMFOHH EDPCJDELACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x78CD990", Offset = "0x78CC390", VA = "0x1878CD990", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, HHLAPEBAPPO<ObscuredBool>, KKGPDKJIHOB<ObscuredBool>, MIIKGEDJHGP<ObscuredBool>, JBEANFFLJAO
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AED90", Offset = "0x9AD790", VA = "0x1809AED90", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AED70", Offset = "0x9AD770", VA = "0x1809AED70", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x78CCD90", Offset = "0x78CB790", VA = "0x1878CCD90")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x78CCD10", Offset = "0x78CB710", VA = "0x1878CCD10")]
		public void MGLGJDFFIIP(MutableOverridableDefaultableObscuredBool OLKLGHOAKNE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BPPOKGNCFHM> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x55D3F80", Offset = "0x55D2980", VA = "0x1855D3F80", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x55D4100", Offset = "0x55D2B00", VA = "0x1855D4100", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F278D0", Offset = "0x3F262D0", VA = "0x183F278D0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x55D3F40", Offset = "0x55D2940", VA = "0x1855D3F40")]
		public SerializedMutableOverridableObscuredEnum(bool IPHIFICKJHD, TObsEnum PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x55D3BF0", Offset = "0x55D25F0", VA = "0x1855D3BF0", Slot = "18")]
		public sealed override BPPOKGNCFHM EDPCJDELACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x55D3DC0", Offset = "0x55D27C0", VA = "0x1855D3DC0", Slot = "19")]
		public sealed override void MAAGMMPIAKJ(BPPOKGNCFHM NMADNLDLIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x55D3CE0", Offset = "0x55D26E0", VA = "0x1855D3CE0", Slot = "20")]
		public sealed override void KAIAKPLEOIP(byte[] MFNPKGKMFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x55D3EC0", Offset = "0x55D28C0", VA = "0x1855D3EC0", Slot = "17")]
		public sealed override void OPIOKFDHGCP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, OIGNMDPNBAC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x78CD640", Offset = "0x78CC040", VA = "0x1878CD640", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x78CD680", Offset = "0x78CC080", VA = "0x1878CD680", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78CD5A0", Offset = "0x78CBFA0", VA = "0x1878CD5A0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78CD540", Offset = "0x78CBF40", VA = "0x1878CD540")]
		public MutableOverridableListObscuredString(bool IPHIFICKJHD, List<ObscuredString> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78CD4A0", Offset = "0x78CBEA0", VA = "0x1878CD4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78CD410", Offset = "0x78CBE10", VA = "0x1878CD410", Slot = "17")]
		public override void OPIOKFDHGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78CCFE0", Offset = "0x78CB9E0", VA = "0x1878CCFE0", Slot = "20")]
		public override void KAIAKPLEOIP(byte[] MFNPKGKMFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78CD0B0", Offset = "0x78CBAB0", VA = "0x1878CD0B0", Slot = "19")]
		public override void MAAGMMPIAKJ(OIGNMDPNBAC NMADNLDLIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78CCE00", Offset = "0x78CB800", VA = "0x1878CCE00", Slot = "18")]
		public override OIGNMDPNBAC EDPCJDELACB()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : MIIKGEDJHGP<Vector3>, JBEANFFLJAO
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
			[Cpp2IlInjected.Address(RVA = "0xE81DE0", Offset = "0xE807E0", VA = "0x180E81DE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x78CE5A0", Offset = "0x78CCFA0", VA = "0x1878CE5A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4EA0920", Offset = "0x4E9F320", VA = "0x184EA0920", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52A6EA0", Offset = "0x52A58A0", VA = "0x1852A6EA0")]
		public OverridableVector3(Vector3 PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x58CBB00", Offset = "0x58CA500", VA = "0x1858CBB00")]
		public OverridableVector3(bool IPHIFICKJHD, Vector3 PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x78CE500", Offset = "0x78CCF00", VA = "0x1878CE500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x78CE4E0", Offset = "0x78CCEE0", VA = "0x1878CE4E0")]
		public static OverridableVector3 MEHFEEABIDG(Vector3 OILNFPPOKDD)
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
