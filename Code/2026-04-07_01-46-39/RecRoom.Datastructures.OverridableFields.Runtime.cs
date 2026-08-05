using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.OverridableFields
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface KFFUYQPLZBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface SYFIHOPYPRH<a> : KFFUYQPLZBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NEJWITXWTWJ<a> : SYFIHOPYPRH<a>, KFFUYQPLZBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		new bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		new a Value
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
	public interface EGRYYMOHWGG<a> : NEJWITXWTWJ<a>, SYFIHOPYPRH<a>, KFFUYQPLZBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class NSVFKCUPDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9969260", Offset = "0x9968260", VA = "0x189969260")]
		public static float? QUFQBHQASDU(this OverridableFloat a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : SYFIHOPYPRH<int>, KFFUYQPLZBU
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
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x10B2150", Offset = "0x10B1150", VA = "0x1810B2150", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99693F0", Offset = "0x99683F0", VA = "0x1899693F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x30C0890", Offset = "0x30BF890", VA = "0x1830C0890", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9969370", Offset = "0x9968370", VA = "0x189969370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableFloat : SYFIHOPYPRH<float>, KFFUYQPLZBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x10B2150", Offset = "0x10B1150", VA = "0x1810B2150", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9969340", Offset = "0x9968340", VA = "0x189969340", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2E31C10", Offset = "0x2E30C10", VA = "0x182E31C10", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99692C0", Offset = "0x99682C0", VA = "0x1899692C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OverridableString : SYFIHOPYPRH<string>, KFFUYQPLZBU
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
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10B2150", Offset = "0x10B1150", VA = "0x1810B2150", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9969420", Offset = "0x9968420", VA = "0x189969420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class WPPENOHFVGR<a, b, c> : NEJWITXWTWJ<b>, SYFIHOPYPRH<b>, KFFUYQPLZBU where a : WPPENOHFVGR<a, b, c> where c : IMessage<c>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract b Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2DB0F30", Offset = "0x2DAFF30", VA = "0x182DB0F30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x872AE80", Offset = "0x8729E80", VA = "0x18872AE80")]
		public WPPENOHFVGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x872B110", Offset = "0x872A110", VA = "0x18872B110")]
		public WPPENOHFVGR(bool a, [NotNull] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x872A470", Offset = "0x8729470", VA = "0x18872A470", Slot = "15")]
		public void AEFWIUARJWL(SYFIHOPYPRH<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x872A7B0", Offset = "0x87297B0", VA = "0x18872A7B0", Slot = "16")]
		public void Copy(SYFIHOPYPRH<b> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x872AC20", Offset = "0x8729C20", VA = "0x18872AC20", Slot = "17")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract c OYVJFFPQBVA();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void CJAEGSOSYKK(c a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void CQNPGVCWVHL(byte[] a);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : WPPENOHFVGR<T, InnerType, ProtobufType> where T : WPPENOHFVGR<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
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
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xE0C750", Offset = "0xE0B750", VA = "0x180E0C750", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF72B40", Offset = "0xF71B40", VA = "0x180F72B40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B5F0", Offset = "0x7B1A5F0", VA = "0x187B1B5F0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B790", Offset = "0x7B1A790", VA = "0x187B1B790")]
		public SerializedMutableOverridableBase(bool overrides, InnerType value)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, VGLOFUAYFPS>
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9969190", Offset = "0x9968190", VA = "0x189969190")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99691F0", Offset = "0x99681F0", VA = "0x1899691F0")]
		public MutableOverridableObscuredInt(bool overrides, ObscuredInt value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99690D0", Offset = "0x99680D0", VA = "0x1899690D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9968F10", Offset = "0x9967F10", VA = "0x189968F10", Slot = "20")]
		public override void CQNPGVCWVHL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9968E60", Offset = "0x9967E60", VA = "0x189968E60", Slot = "19")]
		public override void CJAEGSOSYKK(VGLOFUAYFPS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9968FF0", Offset = "0x9967FF0", VA = "0x189968FF0", Slot = "18")]
		public override VGLOFUAYFPS OYVJFFPQBVA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, TWAJZSDJPVR>
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9968D90", Offset = "0x9967D90", VA = "0x189968D90")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9968DF0", Offset = "0x9967DF0", VA = "0x189968DF0")]
		public MutableOverridableObscuredFloat(bool overrides, ObscuredFloat value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9968CC0", Offset = "0x9967CC0", VA = "0x189968CC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9968AF0", Offset = "0x9967AF0", VA = "0x189968AF0", Slot = "20")]
		public override void CQNPGVCWVHL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9968A30", Offset = "0x9967A30", VA = "0x189968A30", Slot = "19")]
		public override void CJAEGSOSYKK(TWAJZSDJPVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9968BD0", Offset = "0x9967BD0", VA = "0x189968BD0", Slot = "18")]
		public override TWAJZSDJPVR OYVJFFPQBVA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, NPSALNPWJFR>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9967C90", Offset = "0x9966C90", VA = "0x189967C90")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99689C0", Offset = "0x99679C0", VA = "0x1899689C0")]
		public MutableOverridableObscuredBool(bool overrides, ObscuredBool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99688F0", Offset = "0x99678F0", VA = "0x1899688F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99686A0", Offset = "0x99676A0", VA = "0x1899686A0", Slot = "20")]
		public override void CQNPGVCWVHL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99685E0", Offset = "0x99675E0", VA = "0x1899685E0", Slot = "19")]
		public override void CJAEGSOSYKK(NPSALNPWJFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9968780", Offset = "0x9967780", VA = "0x189968780", Slot = "18")]
		public override NPSALNPWJFR OYVJFFPQBVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9968860", Offset = "0x9967860", VA = "0x189968860", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, EGRYYMOHWGG<ObscuredBool>, NEJWITXWTWJ<ObscuredBool>, SYFIHOPYPRH<ObscuredBool>, KFFUYQPLZBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCFC420", Offset = "0xCFB420", VA = "0x180CFC420", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCFC350", Offset = "0xCFB350", VA = "0x180CFC350", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9967C90", Offset = "0x9966C90", VA = "0x189967C90")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9967C10", Offset = "0x9966C10", VA = "0x189967C10")]
		public void AEFWIUARJWL(MutableOverridableDefaultableObscuredBool a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, VGLOFUAYFPS> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C210", Offset = "0x7B1B210", VA = "0x187B1C210", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C4B0", Offset = "0x7B1B4B0", VA = "0x187B1C4B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C150", Offset = "0x7B1B150", VA = "0x187B1C150")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C1E0", Offset = "0x7B1B1E0", VA = "0x187B1C1E0")]
		public SerializedMutableOverridableObscuredEnum(bool overrides, TObsEnum value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BE90", Offset = "0x7B1AE90", VA = "0x187B1BE90", Slot = "18")]
		public sealed override VGLOFUAYFPS OYVJFFPQBVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BBC0", Offset = "0x7B1ABC0", VA = "0x187B1BBC0", Slot = "19")]
		public sealed override void CJAEGSOSYKK(VGLOFUAYFPS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BDB0", Offset = "0x7B1ADB0", VA = "0x187B1BDB0", Slot = "20")]
		public sealed override void CQNPGVCWVHL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C0F0", Offset = "0x7B1B0F0", VA = "0x187B1C0F0", Slot = "17")]
		public sealed override void Reset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, COUEGHUDNCW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9968510", Offset = "0x9967510", VA = "0x189968510", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9968550", Offset = "0x9967550", VA = "0x189968550", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9968480", Offset = "0x9967480", VA = "0x189968480")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9968420", Offset = "0x9967420", VA = "0x189968420")]
		public MutableOverridableListObscuredString(bool overrides, List<ObscuredString> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9968390", Offset = "0x9967390", VA = "0x189968390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9968300", Offset = "0x9967300", VA = "0x189968300", Slot = "17")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9968040", Offset = "0x9967040", VA = "0x189968040", Slot = "20")]
		public override void CQNPGVCWVHL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9967D00", Offset = "0x9966D00", VA = "0x189967D00", Slot = "19")]
		public override void CJAEGSOSYKK(COUEGHUDNCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9968120", Offset = "0x9967120", VA = "0x189968120", Slot = "18")]
		public override COUEGHUDNCW OYVJFFPQBVA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OverridableVector3 : SYFIHOPYPRH<Vector3>, KFFUYQPLZBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x10B2150", Offset = "0x10B1150", VA = "0x1810B2150", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9969520", Offset = "0x9968520", VA = "0x189969520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD561E0", Offset = "0xD551E0", VA = "0x180D561E0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73CFF30", Offset = "0x73CEF30", VA = "0x1873CFF30")]
		public OverridableVector3(Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81CE600", Offset = "0x81CD600", VA = "0x1881CE600")]
		public OverridableVector3(bool overrides, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9969480", Offset = "0x9968480", VA = "0x189969480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9969570", Offset = "0x9968570", VA = "0x189969570")]
		public static implicit operator OverridableVector3(Vector3 val)
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
