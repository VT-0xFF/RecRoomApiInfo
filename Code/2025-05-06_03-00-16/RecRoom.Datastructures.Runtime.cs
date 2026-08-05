using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF070", Offset = "0x7AED870", VA = "0x187AEF070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BMEIMLDNEPI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
	public BMEIMLDNEPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, AHFHPLAHONB, IMIPDJGBCPB, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash EGAIPBFBDLP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF13E0", Offset = "0x7AEFBE0", VA = "0x187AF13E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AF13A0", Offset = "0x7AEFBA0", VA = "0x187AF13A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1420", Offset = "0x7AEFC20", VA = "0x187AF1420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AF15D0", Offset = "0x7AEFDD0", VA = "0x187AF15D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1540", Offset = "0x7AEFD40", VA = "0x187AF1540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEB6410", Offset = "0xEB4C10", VA = "0x180EB6410")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD03120", Offset = "0xD01920", VA = "0x180D03120")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1360", Offset = "0x7AEFB60", VA = "0x187AF1360")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AF14B0", Offset = "0x7AEFCB0", VA = "0x187AF14B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AF0E00", Offset = "0x7AEF600", VA = "0x187AF0E00")]
	public void CopyBounds(SavedExtents PGPJMFPAKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7AF12B0", Offset = "0x7AEFAB0", VA = "0x187AF12B0")]
	public void SetLocalSpaceBounds(Bounds KAONEBCDJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x13DFF40", Offset = "0x13DE740", VA = "0x1813DFF40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF12A0", Offset = "0x7AEFAA0", VA = "0x187AF12A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF0EF0", Offset = "0x7AEF6F0", VA = "0x187AF0EF0")]
	private void NDBMHNHNPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF10A0", Offset = "0x7AEF8A0", VA = "0x187AF10A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF07C0", Offset = "0x7AEEFC0", VA = "0x187AF07C0")]
	public static void CalculateLocalBoundsFor(GameObject KJMBGAPFJAM, [Out] Bounds KAONEBCDJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF0E30", Offset = "0x7AEF630", VA = "0x187AF0E30")]
	private static void DJOEHAKJBDO(Bounds NOAPPAEGHOH, Color JDLOGJMLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7AF12D0", Offset = "0x7AEFAD0", VA = "0x187AF12D0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x188DD40", Offset = "0x188C540", VA = "0x18188DD40")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5795F10", Offset = "0x5794710", VA = "0x185795F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public virtual void CKFOFPNMALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[BMEIMLDNEPI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5795A80", Offset = "0x5794280", VA = "0x185795A80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5794650", Offset = "0x5792E50", VA = "0x185794650", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5795E30", Offset = "0x5794630", VA = "0x185795E30")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NODOAIGCOPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NODOAIGCOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5358370", Offset = "0x5356B70", VA = "0x185358370")]
		internal int HBIKCFGGFCN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[BMEIMLDNEPI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4447010", Offset = "0x4445810", VA = "0x184447010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4447070", Offset = "0x4445870", VA = "0x184447070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4446EF0", Offset = "0x44456F0", VA = "0x184446EF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey BELIEAFHDAH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4446FB0", Offset = "0x44457B0", VA = "0x184446FB0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4446DA0", Offset = "0x44455A0", VA = "0x184446DA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4446A40", Offset = "0x4445240", VA = "0x184446A40", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4445E00", Offset = "0x4444600", VA = "0x184445E00", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4445C70", Offset = "0x4444470", VA = "0x184445C70", Slot = "14")]
	protected virtual string BEGHGBLCJHC(TKeyVal KLDHFHKDFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4445D00", Offset = "0x4444500", VA = "0x184445D00", Slot = "4")]
	public bool ContainsKey(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4446C20", Offset = "0x4445420", VA = "0x184446C20", Slot = "5")]
	public bool TryGetValue(TKey BELIEAFHDAH, [Out] TVal OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4445D60", Offset = "0x4444560", VA = "0x184445D60", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4445D60", Offset = "0x4444560", VA = "0x184445D60", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4446C80", Offset = "0x4445480", VA = "0x184446C80")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[BMEIMLDNEPI]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x57978C0", Offset = "0x57960C0", VA = "0x1857978C0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5797100", Offset = "0x5795900", VA = "0x185797100", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57966B0", Offset = "0x5794EB0", VA = "0x1857966B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JLFBFOJBBGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JIEIBMKLAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T GDCDOMLHCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float LAPPFJGEKGK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int HCBGBNMGOKD = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float PNLDGHDPOAJ = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly JIEIBMKLAPI[] CPIDEKBKOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int MMBHGLLFOBJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BINGBBIEMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBEBA20", Offset = "0xBEA220", VA = "0x180BEBA20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC2EAC0", Offset = "0xC2D2C0", VA = "0x180C2EAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T BCDJGFMIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC99C0", Offset = "0x4DC81C0", VA = "0x184DC99C0")]
	protected JLFBFOJBBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DC9920", Offset = "0x4DC8120", VA = "0x184DC9920")]
	protected JLFBFOJBBGD(int LBLAFDELPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DC9810", Offset = "0x4DC8010", VA = "0x184DC9810")]
	public void OIHLAKEIFNH(float OIKKJHNFKFP, T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CIJJHIELLAF(float GEEOJGFNPAK, float OPADMCNDOMB, [Out] T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AMKHBCFDDOH(float GEEOJGFNPAK, float OPADMCNDOMB, [Out] T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4DC9630", Offset = "0x4DC7E30", VA = "0x184DC9630")]
	public void NNEMBDPLFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KKNDNMMOJEK : JLFBFOJBBGD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AEEA90", Offset = "0x7AED290", VA = "0x187AEEA90", Slot = "4")]
	public override bool CIJJHIELLAF(float GEEOJGFNPAK, float OPADMCNDOMB, [Out] Vector3 OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE950", Offset = "0x7AED150", VA = "0x187AEE950", Slot = "5")]
	public override bool AMKHBCFDDOH(float GEEOJGFNPAK, float OPADMCNDOMB, [Out] Vector3 OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AEEBF0", Offset = "0x7AED3F0", VA = "0x187AEEBF0")]
	public KKNDNMMOJEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LCPHGEMOOFN
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3842C20", Offset = "0x3841420", VA = "0x183842C20")]
	public static AEMMGPOOLPH<T1, T2> NKIHIDGHACP<T1, T2>(T1 NHDPENCEKNG, T2 GAJDADPAMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3842CC0", Offset = "0x38414C0", VA = "0x183842CC0")]
	public static DDJLPKJDJCI<T1, T2, T3> NKIHIDGHACP<T1, T2, T3>(T1 NHDPENCEKNG, T2 GAJDADPAMFE, T3 CHAAMEDDHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x52C8FB0", Offset = "0x52C77B0", VA = "0x1852C8FB0")]
	internal static int BEJFDBFNKKN(int PEMAMPNLGNL, int FJIENKNAHBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D084B0", Offset = "0x6D06CB0", VA = "0x186D084B0")]
	internal static int BEJFDBFNKKN(int PEMAMPNLGNL, int FJIENKNAHBC, int PNMNEIKFGND)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AEMMGPOOLPH<T1, T2> : IComparable<AEMMGPOOLPH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 DLOAPALFGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 LALPMKOPALF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x49E74C0", Offset = "0x49E5CC0", VA = "0x1849E74C0")]
	public AEMMGPOOLPH(T1 NHDPENCEKNG, T2 GAJDADPAMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x49E5A70", Offset = "0x49E4270", VA = "0x1849E5A70", Slot = "4")]
	public int CompareTo(AEMMGPOOLPH<T1, T2> PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x49E5FE0", Offset = "0x49E47E0", VA = "0x1849E5FE0", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x49E68D0", Offset = "0x49E50D0", VA = "0x1849E68D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x49E72D0", Offset = "0x49E5AD0", VA = "0x1849E72D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DDJLPKJDJCI<T1, T2, T3> : IComparable<DDJLPKJDJCI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 DLOAPALFGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 LALPMKOPALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 EMLNOPENKJO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68C1650", Offset = "0x68BFE50", VA = "0x1868C1650")]
	public DDJLPKJDJCI(T1 NHDPENCEKNG, T2 GAJDADPAMFE, T3 CHAAMEDDHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68C0E40", Offset = "0x68BF640", VA = "0x1868C0E40", Slot = "4")]
	public int CompareTo(DDJLPKJDJCI<T1, T2, T3> PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68C10B0", Offset = "0x68BF8B0", VA = "0x1868C10B0", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68C12F0", Offset = "0x68BFAF0", VA = "0x1868C12F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68C14A0", Offset = "0x68BFCA0", VA = "0x1868C14A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve MGOHPPFGKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T GLFPOAPEJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T EHJPCNNLAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B146C0", Offset = "0x2B12EC0", VA = "0x182B146C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B14770", Offset = "0x2B12F70", VA = "0x182B14770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float AIPIGGGAIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xBD7F00", Offset = "0xBD6700", VA = "0x180BD7F00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5A56480", Offset = "0x5A54C80", VA = "0x185A56480")]
	public T BCLGKHCPIKO(float NACLDKPPPKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5A55F30", Offset = "0x5A54730", VA = "0x185A55F30")]
	public T ALMPAHPNAHM(float NACLDKPPPKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GALPNNEBFKP(T ANGFJALIIBO, T LNEMONKDKMJ, float NACLDKPPPKG);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE4A0", Offset = "0x7AECCA0", VA = "0x187AEE4A0", Slot = "4")]
	protected override float GALPNNEBFKP(float ANGFJALIIBO, float LNEMONKDKMJ, float NACLDKPPPKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE4E0", Offset = "0x7AECCE0", VA = "0x187AEE4E0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16D1D70", Offset = "0x16D0570", VA = "0x1816D1D70", Slot = "4")]
	protected override Vector3 GALPNNEBFKP(Vector3 ANGFJALIIBO, Vector3 LNEMONKDKMJ, float NACLDKPPPKG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF23A0", Offset = "0x7AF0BA0", VA = "0x187AF23A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC9E0", Offset = "0x7AEB1E0", VA = "0x187AEC9E0", Slot = "4")]
	protected override Color GALPNNEBFKP(Color ANGFJALIIBO, Color LNEMONKDKMJ, float NACLDKPPPKG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7AECAA0", Offset = "0x7AEB2A0", VA = "0x187AECAA0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JMAKDBFBLEA : AEEOJFCDIMH<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE900", Offset = "0x7AED100", VA = "0x187AEE900")]
	public JMAKDBFBLEA(int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE890", Offset = "0x7AED090", VA = "0x187AEE890", Slot = "6")]
	protected override uint CKAKLJODLMD(uint EGAIPBFBDLP, string OPMIAMEJKDH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FJFEMOLLPJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FJFEMOLLPJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NKAIILPIGDH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BNGPIEIGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int MPENDDAMLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int AKPHFNFOHLD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x52CB160", Offset = "0x52C9960", VA = "0x1852CB160")]
	private NKAIILPIGDH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HMIIOBNJAGK, int IGFFMGIBEEI, int JALDPIJOHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x534DA00", Offset = "0x534C200", VA = "0x18534DA00")]
	public static NKAIILPIGDH<T> CJOJELENPLJ()
	{
		return default(NKAIILPIGDH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x534DB00", Offset = "0x534C300", VA = "0x18534DB00")]
	public (int, int, Task<T>) ODMKHMKECKP(int EIOPAHLHHKC, [Optional] CancellationToken DNHBNMHIDAC, double FOLPOAMFDOE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x534F990", Offset = "0x534E190", VA = "0x18534F990")]
	public void OIBDNLFPLOI(int EIOPAHLHHKC, int JALDPIJOHOL, [In] T HLPIAOANGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class APELGCJMJAP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBF90", Offset = "0x7AEA790", VA = "0x187AEBF90")]
	public static NKAIILPIGDH<OLONILFLODF> CJOJELENPLJ()
	{
		return default(NKAIILPIGDH<OLONILFLODF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBFE0", Offset = "0x7AEA7E0", VA = "0x187AEBFE0")]
	public static void OIBDNLFPLOI([In] this NKAIILPIGDH<OLONILFLODF> NFOGFJOGLPE, int EIOPAHLHHKC, int JALDPIJOHOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class PDKOGHFNHHG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> PLHMKJONDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> CJDDFNOIPMG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3FED240", Offset = "0x3FEBA40", VA = "0x183FED240", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KFFGFCMACFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> IBFMKGDJJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x49633D0", Offset = "0x4961BD0", VA = "0x1849633D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NFABEMFBIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4F503A0", Offset = "0x4F4EBA0", VA = "0x184F503A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x554FBB0", Offset = "0x554E3B0", VA = "0x18554FBB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x554FC10", Offset = "0x554E410", VA = "0x18554FC10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x554F340", Offset = "0x554DB40", VA = "0x18554F340")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x554F490", Offset = "0x554DC90", VA = "0x18554F490", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x554F970", Offset = "0x554E170", VA = "0x18554F970", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x554F2A0", Offset = "0x554DAA0", VA = "0x18554F2A0", Slot = "9")]
	public void Add(TKey BELIEAFHDAH, TVal OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x554F2F0", Offset = "0x554DAF0", VA = "0x18554F2F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x554F530", Offset = "0x554DD30", VA = "0x18554F530", Slot = "8")]
	public bool ContainsKey(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x554F580", Offset = "0x554DD80", VA = "0x18554F580", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x554F8F0", Offset = "0x554E0F0", VA = "0x18554F8F0", Slot = "10")]
	public bool Remove(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x554F930", Offset = "0x554E130", VA = "0x18554F930", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x554FA30", Offset = "0x554E230", VA = "0x18554FA30", Slot = "11")]
	public bool TryGetValue(TKey BELIEAFHDAH, [Out] TVal OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x554F640", Offset = "0x554DE40", VA = "0x18554F640", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x554F5C0", Offset = "0x554DDC0", VA = "0x18554F5C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CPIDEKBKOPO, int KNKIMBLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x554F240", Offset = "0x554DA40", VA = "0x18554F240")]
	public bool AEJGKIILIJC(TVal BELIEAFHDAH, [Out] TKey OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x554F800", Offset = "0x554E000", VA = "0x18554F800")]
	private void PLAGMMOHBKA(TKey BELIEAFHDAH, TVal DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x554F3A0", Offset = "0x554DBA0", VA = "0x18554F3A0")]
	private void CHLNLEPHACJ(TKey BELIEAFHDAH, TVal DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x554F6E0", Offset = "0x554DEE0", VA = "0x18554F6E0")]
	private bool HNFKOFCEHLG(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x554FA90", Offset = "0x554E290", VA = "0x18554FA90")]
	public PDKOGHFNHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class FGNHBNINDEF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FGNHBNINDEF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x44A1EB0", Offset = "0x44A06B0", VA = "0x1844A1EB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x44A87E0", Offset = "0x44A6FE0", VA = "0x1844A87E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x44A96C0", Offset = "0x44A7EC0", VA = "0x1844A96C0")]
		public Enumerator(FGNHBNINDEF<T> HOAEKOMMHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x44A6DD0", Offset = "0x44A55D0", VA = "0x1844A6DD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x44A7950", Offset = "0x44A6150", VA = "0x1844A7950", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x44A63F0", Offset = "0x44A4BF0", VA = "0x1844A63F0")]
		private void BNOAAFAPNGO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] MLOHNMJPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int IFOFOJHAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int JKKKFFDIIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int JLNEBEJFOHB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x48BD910", Offset = "0x48BC110", VA = "0x1848BD910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x48BDBB0", Offset = "0x48BC3B0", VA = "0x1848BDBB0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x48BD830", Offset = "0x48BC030", VA = "0x1848BD830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x48BF6F0", Offset = "0x48BDEF0", VA = "0x1848BF6F0")]
	public FGNHBNINDEF(int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x48BF0E0", Offset = "0x48BD8E0", VA = "0x1848BF0E0")]
	public void OIHLAKEIFNH(T NACLDKPPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x48BEE00", Offset = "0x48BD600", VA = "0x1848BEE00")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x48BE610", Offset = "0x48BCE10", VA = "0x1848BE610")]
	public void IJBPEGBCIGI(int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48BDEE0", Offset = "0x48BC6E0", VA = "0x1848BDEE0")]
	public void IBCENFPGIMP(T[] CPIDEKBKOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x48BDD30", Offset = "0x48BC530", VA = "0x1848BDD30")]
	public Enumerator DPNIJJHCOGM()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x48BF410", Offset = "0x48BDC10", VA = "0x1848BF410", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x48BF410", Offset = "0x48BDC10", VA = "0x1848BF410", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x48BEBA0", Offset = "0x48BD3A0", VA = "0x1848BEBA0")]
	private int LEIKALHEFDO(int FPEOONOJHML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x48BD8E0", Offset = "0x48BC0E0", VA = "0x1848BD8E0")]
	private int BDCPNJOCLNA(int FPEOONOJHML)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NKJLFPGANPE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> GHHNADPLJNA(TRequest JHLBOHEIAIJ, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum JIMHNOCDMGP
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NMBFILBKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float BIOGCFAMBLL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan CLOOMMAHMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int OCEJLKGHANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JIMHNOCDMGP LJPBHFGFODC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly NMBFILBKOAK CONOIFPANGO;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float HNENHGKEMHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5356500", Offset = "0x5354D00", VA = "0x185356500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan JKHLIMPDFAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x53566C0", Offset = "0x5354EC0", VA = "0x1853566C0")]
		public NMBFILBKOAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct OPPPGJIBMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest JHLBOHEIAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken DNHBNMHIDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> MGDEAOFNAAC;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5490B20", Offset = "0x548F320", VA = "0x185490B20")]
		public OPPPGJIBMBA(TRequest JHLBOHEIAIJ, TaskCompletionSource<TResult> MGDEAOFNAAC, CancellationToken DNHBNMHIDAC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ILLANHFJMJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NKJLFPGANPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B82B90", Offset = "0x4B81390", VA = "0x184B82B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B83790", Offset = "0x4B81F90", VA = "0x184B83790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct BDNACAIKION : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NKJLFPGANPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OPPPGJIBMBA <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DA52C0", Offset = "0x5DA3AC0", VA = "0x185DA52C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6550", Offset = "0x5DA4D50", VA = "0x185DA6550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource IIGPKBAGMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<OPPPGJIBMBA> EIPEDLMOAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NMBFILBKOAK ICFMLPPBBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GHHNADPLJNA MFGOJGOAEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task DMJEJAJBGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int PDMOEAFEHOI;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5353FA0", Offset = "0x53527A0", VA = "0x185353FA0")]
	public NKJLFPGANPE(GHHNADPLJNA MFGOJGOAEHN, [Optional] NMBFILBKOAK ICFMLPPBBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5352DF0", Offset = "0x53515F0", VA = "0x185352DF0")]
	public Task<TResult> JPCJCFPIGNN(TRequest JHLBOHEIAIJ, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5352940", Offset = "0x5351140", VA = "0x185352940")]
	private void HNJJIOOHBMP(OPPPGJIBMBA NKGCLEOGCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5352870", Offset = "0x5351070", VA = "0x185352870")]
	[AsyncStateMachine(typeof(NKJLFPGANPE<, >.ILLANHFJMJM))]
	private Task GNCIJHKLBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5353560", Offset = "0x5351D60", VA = "0x185353560")]
	private OPPPGJIBMBA KFPOFLONDED()
	{
		return default(OPPPGJIBMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5353D20", Offset = "0x5352520", VA = "0x185353D20")]
	[AsyncStateMachine(typeof(NKJLFPGANPE<, >.BDNACAIKION))]
	private Task NACJFGAGCOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5352590", Offset = "0x5350D90", VA = "0x185352590")]
	private void CGOPOFKIABF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5352690", Offset = "0x5350E90", VA = "0x185352690", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class IOPKEJDDFBB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> GIPAMJGJGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> JDJJOAABAAP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3FED240", Offset = "0x3FEBA40", VA = "0x183FED240", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KFFGFCMACFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3856530", Offset = "0x3854D30", VA = "0x183856530", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B8F0A0", Offset = "0x4B8D8A0", VA = "0x184B8F0A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x48FF6F0", Offset = "0x48FDEF0", VA = "0x1848FF6F0", Slot = "11")]
	public void Add(T BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E590", Offset = "0x4B8CD90", VA = "0x184B8E590")]
	public bool HBGAGBEBOKC(T BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4B8ECC0", Offset = "0x4B8D4C0", VA = "0x184B8ECC0", Slot = "15")]
	public bool Remove(T BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E500", Offset = "0x4B8CD00", VA = "0x184B8E500", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x492E9B0", Offset = "0x492D1B0", VA = "0x18492E9B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E3B0", Offset = "0x4B8CBB0", VA = "0x184B8E3B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E450", Offset = "0x4B8CC50", VA = "0x184B8E450", Slot = "13")]
	public bool Contains(T BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E4A0", Offset = "0x4B8CCA0", VA = "0x184B8E4A0", Slot = "14")]
	public void CopyTo(T[] CPIDEKBKOPO, int KNKIMBLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x48C2A40", Offset = "0x48C1240", VA = "0x1848C2A40", Slot = "6")]
	public int IndexOf(T BLFLGKHLJNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E790", Offset = "0x4B8CF90", VA = "0x184B8E790", Slot = "7")]
	public void Insert(int FPEOONOJHML, T BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B8EB70", Offset = "0x4B8D370", VA = "0x184B8EB70", Slot = "8")]
	public void RemoveAt(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B8EE40", Offset = "0x4B8D640", VA = "0x184B8EE40")]
	public IOPKEJDDFBB()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2984D60", Offset = "0x2983560", VA = "0x182984D60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x24A6000", Offset = "0x24A4800", VA = "0x1824A6000")]
		public SerializedGuid([In] Guid BGPPHEMBCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1840", Offset = "0x7AF0040", VA = "0x187AF1840")]
		public static SerializedGuid NOCJJFGBKEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF17D0", Offset = "0x7AEFFD0", VA = "0x187AF17D0")]
		public static SerializedGuid LONHHBEHPMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1770", Offset = "0x7AEFF70", VA = "0x187AF1770")]
		public bool KBDBMNHHFOB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1940", Offset = "0x7AF0140", VA = "0x187AF1940", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF18C0", Offset = "0x7AF00C0", VA = "0x187AF18C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1690", Offset = "0x7AEFE90", VA = "0x187AF1690", Slot = "7")]
		public bool Equals(SerializedGuid PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AF16D0", Offset = "0x7AEFED0", VA = "0x187AF16D0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1760", Offset = "0x7AEFF60", VA = "0x187AF1760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1660", Offset = "0x7AEFE60", VA = "0x187AF1660", Slot = "6")]
		public int CompareTo(SerializedGuid PGPJMFPAKOO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CECJFAJNCHG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type LJBNJPONHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string INPGMEPBFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool LKFKAGFJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool DLBBAMPIKNO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC970", Offset = "0x7AEB170", VA = "0x187AEC970")]
	public CECJFAJNCHG(Type DODFAHIGEJI, string DOHLIEPOEHG, bool DNLDNPBOBMD = false, bool ONMMCOFHPJA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JLKFNDNBLNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int BGMOIDAIGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> NKCAKCFKELF(float OIKKJHNFKFP, [Optional] float? IIEMBFIOFMC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OCKNBBBGAHN(float OIKKJHNFKFP, T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNEMBDPLFBE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class GPCKFKGHLJE<T> : JLKFNDNBLNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class BAPFPNKAILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float CEMOBPGGHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T GDCDOMLHCOE;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BAPFPNKAILO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EPBKMPLJNKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EPBKMPLJNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x443DF20", Offset = "0x443C720", VA = "0x18443DF20")]
		internal bool GFEHLKJLBDB(BAPFPNKAILO sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float GDJDOBDGGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float PPMCFOMLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<BAPFPNKAILO> CBGHKBODDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private OMDHBJNNJHE<BAPFPNKAILO> LLPECLIAHAI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BGMOIDAIGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x49D9240", Offset = "0x49D7A40", VA = "0x1849D9240", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x49D9F80", Offset = "0x49D8780", VA = "0x1849D9F80")]
	public GPCKFKGHLJE(float OAEIHGIFNNF, float JEOKIBAIJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x49D9BF0", Offset = "0x49D83F0", VA = "0x1849D9BF0", Slot = "6")]
	public bool OCKNBBBGAHN(float OIKKJHNFKFP, T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x49D92B0", Offset = "0x49D7AB0", VA = "0x1849D92B0", Slot = "5")]
	public IEnumerable<T> NKCAKCFKELF(float OIKKJHNFKFP, float? IIEMBFIOFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x49D9B40", Offset = "0x49D8340", VA = "0x1849D9B40", Slot = "7")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x49D9990", Offset = "0x49D8190", VA = "0x1849D9990")]
	private void NLGCOLAFNIL(float OIKKJHNFKFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MNOAJGMJEGM<T> : JLKFNDNBLNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DINAFKMBKOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T GDCDOMLHCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float CEMOBPGGHAN;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x43E62D0", Offset = "0x43E4AD0", VA = "0x1843E62D0")]
		public DINAFKMBKOM(T OPMIAMEJKDH, float OIKKJHNFKFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class BBGDJFKODPD : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MNOAJGMJEGM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public BBGDJFKODPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D96DF0", Offset = "0x5D955F0", VA = "0x185D96DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D97320", Offset = "0x5D95B20", VA = "0x185D97320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D97160", Offset = "0x5D95960", VA = "0x185D97160", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x494F450", Offset = "0x494DC50", VA = "0x18494F450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float OAEIHGIFNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float JEOKIBAIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<DINAFKMBKOM> CBGHKBODDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int IFOFOJHAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int KEKBBMIINCJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int BGMOIDAIGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5297C00", Offset = "0x5296400", VA = "0x185297C00")]
	public MNOAJGMJEGM(float OAEIHGIFNNF, float JEOKIBAIJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5297940", Offset = "0x5296140", VA = "0x185297940", Slot = "6")]
	public bool OCKNBBBGAHN(float OIKKJHNFKFP, T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5297460", Offset = "0x5295C60", VA = "0x185297460", Slot = "8")]
	public int GFDFFPIHKCJ(float OIKKJHNFKFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5297570", Offset = "0x5295D70", VA = "0x185297570", Slot = "5")]
	[IteratorStateMachine(typeof(MNOAJGMJEGM<>.BBGDJFKODPD))]
	public IEnumerable<T> NKCAKCFKELF(float OIKKJHNFKFP, float? IIEMBFIOFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5297630", Offset = "0x5295E30", VA = "0x185297630", Slot = "7")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x52970F0", Offset = "0x52958F0", VA = "0x1852970F0")]
	private void ADPMGFPNFBF(float OIKKJHNFKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5297390", Offset = "0x5295B90", VA = "0x185297390")]
	private DINAFKMBKOM EHKOAMPJIMN()
	{
		return default(DINAFKMBKOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BGHFCMFIENI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct CNMINICBJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long GMBILEKINLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long EDJFMLKMJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int JLLMCEHICOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int HKJBAMGCLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool OEBCKFNPAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string HGIGEAILJKP;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x64E1CB0", Offset = "0x64E04B0", VA = "0x1864E1CB0")]
		public CNMINICBJIH(long GMBILEKINLA, int JLLMCEHICOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x64E1C80", Offset = "0x64E0480", VA = "0x1864E1C80")]
		public CNMINICBJIH(long GMBILEKINLA, long EDJFMLKMJGH, int JLLMCEHICOM, int HKJBAMGCLAN, bool OEBCKFNPAGF, string HGIGEAILJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x64E1B70", Offset = "0x64E0370", VA = "0x1864E1B70")]
		public int KBCGEHEDMJA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x64E1BC0", Offset = "0x64E03C0", VA = "0x1864E1BC0")]
		public int KHIOPOPBNGC(int IJAPALLJDCD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x64E1B10", Offset = "0x64E0310", VA = "0x1864E1B10")]
		public double FINFKLKIJEO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64E1BE0", Offset = "0x64E03E0", VA = "0x1864E1BE0")]
		public CNMINICBJIH OCEFHDHFCMN(long EDJFMLKMJGH, int HKJBAMGCLAN)
		{
			return default(CNMINICBJIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class KHCJHMNAJKC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct KELEFAAIAJE<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public KHCJHMNAJKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<KHCJHMNAJKC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private KHCJHMNAJKC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4EFACE0", Offset = "0x4EF94E0", VA = "0x184EFACE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x43FB080", Offset = "0x43F9880", VA = "0x1843FB080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey FIEPPEJGGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly BGHFCMFIENI<TKey> NIBJMJJGOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly LLPKKNNAIAE NOMHFHBJHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<KHCJHMNAJKC> CCIOJMJCBOF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string MAPEELIJHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4F04F20", Offset = "0x4F03720", VA = "0x184F04F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<KHCJHMNAJKC> MHBEANDDIPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4F05370", Offset = "0x4F03B70", VA = "0x184F05370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public CNMINICBJIH CJNNPKCKHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4F053B0", Offset = "0x4F03BB0", VA = "0x184F053B0")]
			[CompilerGenerated]
			get
			{
				return default(CNMINICBJIH);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4F053D0", Offset = "0x4F03BD0", VA = "0x184F053D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4F05400", Offset = "0x4F03C00", VA = "0x184F05400")]
		internal KHCJHMNAJKC(BGHFCMFIENI<TKey> NIBJMJJGOBF, TKey BELIEAFHDAH, LLPKKNNAIAE NOMHFHBJHNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4F051C0", Offset = "0x4F039C0", VA = "0x184F051C0")]
		public KHCJHMNAJKC EFLFAJPGABH(TKey BELIEAFHDAH, [Optional] LLPKKNNAIAE? BJCMJKFEIBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x39927D0", Offset = "0x3990FD0", VA = "0x1839927D0")]
		[AsyncStateMachine(typeof(KELEFAAIAJE<>))]
		public Task<T> CKJAEGPBEKJ<T>(TKey BELIEAFHDAH, Func<KHCJHMNAJKC, Task<T>> JPLDGHHMNAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4F04F70", Offset = "0x4F03770", VA = "0x184F04F70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NBLDFLGFMHI : IEnumerable<(TKey, List<TKey>, CNMINICBJIH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CNMINICBJIH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, CNMINICBJIH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BGHFCMFIENI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, CNMINICBJIH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, CNMINICBJIH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2982B50", Offset = "0x2981350", VA = "0x182982B50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CNMINICBJIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x52DBC80", Offset = "0x52DA480", VA = "0x1852DBC80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2982C40", Offset = "0x2981440", VA = "0x182982C40")]
		[DebuggerHidden]
		public NBLDFLGFMHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4880B70", Offset = "0x487F370", VA = "0x184880B70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x52DB7C0", Offset = "0x52D9FC0", VA = "0x1852DB7C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x52DB770", Offset = "0x52D9F70", VA = "0x1852DB770")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x52DBC30", Offset = "0x52DA430", VA = "0x1852DBC30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x52DBB60", Offset = "0x52DA360", VA = "0x1852DBB60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CNMINICBJIH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x443D1F0", Offset = "0x443B9F0", VA = "0x18443D1F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IJBGNBCALCO : IEnumerable<(TKey, List<TKey>, CNMINICBJIH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CNMINICBJIH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, CNMINICBJIH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KHCJHMNAJKC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KHCJHMNAJKC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public BGHFCMFIENI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<KHCJHMNAJKC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, CNMINICBJIH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, CNMINICBJIH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2982B50", Offset = "0x2981350", VA = "0x182982B50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CNMINICBJIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4B79A40", Offset = "0x4B78240", VA = "0x184B79A40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2982C40", Offset = "0x2981440", VA = "0x182982C40")]
		[DebuggerHidden]
		public IJBGNBCALCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4B79AA0", Offset = "0x4B782A0", VA = "0x184B79AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4B790F0", Offset = "0x4B778F0", VA = "0x184B790F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4B79030", Offset = "0x4B77830", VA = "0x184B79030")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4B79090", Offset = "0x4B77890", VA = "0x184B79090")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4B799F0", Offset = "0x4B781F0", VA = "0x184B799F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4B798B0", Offset = "0x4B780B0", VA = "0x184B798B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CNMINICBJIH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4B799B0", Offset = "0x4B781B0", VA = "0x184B799B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, CNMINICBJIH, LLPKKNNAIAE> LOBJCICEMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, CNMINICBJIH, LLPKKNNAIAE> NJOCPHJDLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<BGHFCMFIENI<TKey>, LLPKKNNAIAE> OEJNIDEEMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly KHCJHMNAJKC HMCCPPBHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool HGKGNONOPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int LFCPBOAJNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch ACAPFOHBAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int FPOEOGNMBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string NKEHGCDOLHG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KHCJHMNAJKC PKOGOIFPHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string MAPEELIJHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E28D80", Offset = "0x5E27580", VA = "0x185E28D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E290B0", Offset = "0x5E278B0", VA = "0x185E290B0")]
	public BGHFCMFIENI(TKey DKDPKBJGKCE, LLPKKNNAIAE NOMHFHBJHNN, [Optional] int? JLLMCEHICOM, [Optional][CanBeNull] Stopwatch ACAPFOHBAGA, [Optional] Action<TKey, CNMINICBJIH, LLPKKNNAIAE> LOBJCICEMJF, [Optional] Action<TKey, CNMINICBJIH, LLPKKNNAIAE> NJOCPHJDLGA, [Optional] Action<BGHFCMFIENI<TKey>, LLPKKNNAIAE> OEJNIDEEMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E28F60", Offset = "0x5E27760", VA = "0x185E28F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E28DE0", Offset = "0x5E275E0", VA = "0x185E28DE0")]
	[IteratorStateMachine(typeof(BGHFCMFIENI<>.NBLDFLGFMHI))]
	public IEnumerable<(TKey, List<TKey>, CNMINICBJIH)> CFKDCJGNMGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E80", Offset = "0x5E27680", VA = "0x185E28E80")]
	[IteratorStateMachine(typeof(BGHFCMFIENI<>.IJBGNBCALCO))]
	private IEnumerable<(TKey, List<TKey>, CNMINICBJIH)> CFKDCJGNMGK(List<TKey> CGOKOPBMMLE, KHCJHMNAJKC PFDDAGHNIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5E29030", Offset = "0x5E27830", VA = "0x185E29030")]
	private (long, int) JEJDHEPPNAO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class FHINCLFFKEF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut MBOEKIDNBLF(BGHFCMFIENI<TKey> NIBJMJJGOBF);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected FHINCLFFKEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class CPNLIMKIJKG<TKey> : FHINCLFFKEF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string MOJDEABNJNC(TKey BELIEAFHDAH);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x64E42A0", Offset = "0x64E2AA0", VA = "0x1864E42A0")]
	private static string IJGFDIKCLNO(TKey BELIEAFHDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x64E4430", Offset = "0x64E2C30", VA = "0x1864E4430", Slot = "4")]
	public override string MBOEKIDNBLF(BGHFCMFIENI<TKey> NIBJMJJGOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x64E42E0", Offset = "0x64E2AE0", VA = "0x1864E42E0")]
	public string MBOEKIDNBLF(BGHFCMFIENI<TKey> NIBJMJJGOBF, [NotNull] MOJDEABNJNC PFFABLIFHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AHLPMJGECJF(BGHFCMFIENI<TKey> NIBJMJJGOBF, [NotNull] MOJDEABNJNC PFFABLIFHNF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4B97B30", Offset = "0x4B96330", VA = "0x184B97B30")]
	protected CPNLIMKIJKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class LJKIMNOPPBJ<TKey> : FHINCLFFKEF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string OFJNBPKCDHE(TKey BELIEAFHDAH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string KEBPNMDGIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double GLABPIOAHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool MKBBHCKFEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int BELOJMPDPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> KJDADEMOMKH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2710", Offset = "0x4FE0F10", VA = "0x184FE2710")]
	private static string IJGFDIKCLNO(TKey BELIEAFHDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4FE3320", Offset = "0x4FE1B20", VA = "0x184FE3320")]
	public LJKIMNOPPBJ(string KEBPNMDGIBC = "F2", double GLABPIOAHOJ = double.MaxValue, bool MKBBHCKFEMF = false, int BELOJMPDPGH = int.MaxValue, [Optional] ISet<string> KJDADEMOMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4FE29C0", Offset = "0x4FE11C0", VA = "0x184FE29C0", Slot = "4")]
	public override Dictionary<string, string> MBOEKIDNBLF(BGHFCMFIENI<TKey> NIBJMJJGOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4FE30E0", Offset = "0x4FE18E0", VA = "0x184FE30E0")]
	private bool NGBPCPPFFCG(string NAOFPCILMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2AA0", Offset = "0x4FE12A0", VA = "0x184FE2AA0")]
	public Dictionary<string, string> MBOEKIDNBLF(BGHFCMFIENI<TKey> NIBJMJJGOBF, OFJNBPKCDHE PFFABLIFHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2750", Offset = "0x4FE0F50", VA = "0x184FE2750")]
	private string LONNJJINAKD(StringBuilder DMAEKLHHIEI, List<TKey> BCIEBLBEPJA, OFJNBPKCDHE PFFABLIFHNF, bool JCFDKGGBOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4FE31C0", Offset = "0x4FE19C0", VA = "0x184FE31C0")]
	private static void OLJNDHBNGFM(StringBuilder FFFJDFPANEP, string KHOIELCLIGD, bool FBBBBDCCOIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NHOPHPFKBEO<TKey> : CPNLIMKIJKG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EBLNHDNLOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MOJDEABNJNC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static NHOPHPFKBEO<TKey> DJLOIKDDKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] BPHLFIEONFK;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5302D00", Offset = "0x5301500", VA = "0x185302D00")]
	private NHOPHPFKBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5301CA0", Offset = "0x53004A0", VA = "0x185301CA0", Slot = "5")]
	protected override string AHLPMJGECJF(BGHFCMFIENI<TKey> NIBJMJJGOBF, MOJDEABNJNC PFFABLIFHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5302AC0", Offset = "0x53012C0", VA = "0x185302AC0")]
	[CompilerGenerated]
	internal static string KLNGDLCDHDF(string IBLLGDFNLLH, TKey BELIEAFHDAH, EBLNHDNLOHG P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class MHGHMGHAKAF : BGHFCMFIENI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class FJLEELJHFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<MHGHMGHAKAF, LLPKKNNAIAE> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FJLEELJHFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDF60", Offset = "0x7AEC760", VA = "0x187AEDF60")]
		internal void JJOLHCHHJNB(BGHFCMFIENI<string> timer, LLPKKNNAIAE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7AEEDE0", Offset = "0x7AED5E0", VA = "0x187AEEDE0")]
	public MHGHMGHAKAF(LLPKKNNAIAE NOMHFHBJHNN, [Optional] string JFIIMGPBPKJ, [Optional] int? JLLMCEHICOM, [Optional] Stopwatch ACAPFOHBAGA, [Optional] Action<string, CNMINICBJIH, LLPKKNNAIAE> LOBJCICEMJF, [Optional] Action<string, CNMINICBJIH, LLPKKNNAIAE> NJOCPHJDLGA, [Optional] Action<MHGHMGHAKAF, LLPKKNNAIAE> OEJNIDEEMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEED20", Offset = "0x7AED520", VA = "0x187AEED20")]
	private static Action<BGHFCMFIENI<string>, LLPKKNNAIAE> EFIPJGIHBJG(Action<MHGHMGHAKAF, LLPKKNNAIAE> NELMOECDPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class IFPFJOMLNHE
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class MJMGCMCNBNC : IFPFJOMLNHE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static IFPFJOMLNHE DJLOIKDDKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7AEEF30", Offset = "0x7AED730", VA = "0x187AEEF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float FPDKKNJNAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x11C36A0", Offset = "0x11C1EA0", VA = "0x1811C36A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF020", Offset = "0x7AED820", VA = "0x187AEF020")]
		public MJMGCMCNBNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static IFPFJOMLNHE CMPPIMBEDOK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static IFPFJOMLNHE CONOIFPANGO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE730", Offset = "0x7AECF30", VA = "0x187AEE730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float FPDKKNJNAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected IFPFJOMLNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IAIDKAIACPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface GOANNPAHNKI<T> : IAIDKAIACPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> PKNGMGKPCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	KJPDFMLMKLI<T> BHCHNLDLDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class ICPLPOHEDHL
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x37D75F0", Offset = "0x37D5DF0", VA = "0x1837D75F0")]
	public static GOANNPAHNKI<TResource> LNBBCHLECAP<TResource, TId>(this GNDJEFKFJMI<TId, TResource> JCIIFEEGFBE, TId MLBCMOLHELH, [Optional] Func<TId, CancellationToken, Task<TResource>>? GMEIGGEMPFG) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KLEGCAMBCKL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class AAMEFEKFAEJ<T> : JLIPNKFLGEL<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> PKNGMGKPCFI
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override KJPDFMLMKLI<T?> BHCHNLDLDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x495A9D0", Offset = "0x49591D0", VA = "0x18495A9D0")]
		public AAMEFEKFAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "10")]
		protected override void FBKFMPFCODD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class GOLPGNGBECJ<T> : JLIPNKFLGEL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T HIJPEKCHALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? PLAKEBFPHGI;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> PKNGMGKPCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override KJPDFMLMKLI<T> BHCHNLDLDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x49D7510", Offset = "0x49D5D10", VA = "0x1849D7510")]
		public GOLPGNGBECJ(T KAMABMPPAPM, Action<T>? HPFEMIAMAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x49D7460", Offset = "0x49D5C60", VA = "0x1849D7460", Slot = "10")]
		protected override void FBKFMPFCODD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class ACBAHIAABDP<T> : JLIPNKFLGEL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> PKNGMGKPCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override KJPDFMLMKLI<T> BHCHNLDLDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x495B260", Offset = "0x4959A60", VA = "0x18495B260")]
		public ACBAHIAABDP(Exception HNILHIIFGAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "10")]
		protected override void FBKFMPFCODD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class HHBJPKMBAGE<T> : JLIPNKFLGEL<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JDDGMGPCCCN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<GOANNPAHNKI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<GOANNPAHNKI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4D5C020", Offset = "0x4D5A820", VA = "0x184D5C020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4D5CA00", Offset = "0x4D5B200", VA = "0x184D5CA00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct EOKPDJFBBCF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<GOANNPAHNKI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<GOANNPAHNKI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x443A260", Offset = "0x4438A60", VA = "0x18443A260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x443A4F0", Offset = "0x4438CF0", VA = "0x18443A4F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<GOANNPAHNKI<T>> JOFLGGLLDBI;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> PKNGMGKPCFI
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KJPDFMLMKLI<T> BHCHNLDLDDM
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D650", Offset = "0x4A4BE50", VA = "0x184A4D650")]
		public HHBJPKMBAGE(Task<GOANNPAHNKI<T>> BFOIMBMKJIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D120", Offset = "0x4A4B920", VA = "0x184A4D120", Slot = "10")]
		protected override void FBKFMPFCODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D1B0", Offset = "0x4A4B9B0", VA = "0x184A4D1B0")]
		[AsyncStateMachine(typeof(HHBJPKMBAGE<>.JDDGMGPCCCN))]
		[CompilerGenerated]
		internal static Task<T> JHBKCOKGAKH(Task<GOANNPAHNKI<T>> BFOIMBMKJIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D570", Offset = "0x4A4BD70", VA = "0x184A4D570")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HHBJPKMBAGE<>.EOKPDJFBBCF))]
		internal static Task OPBEJEGNOHN(Task<GOANNPAHNKI<T>> BFOIMBMKJIA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class CFALGDAJCCN<TIn, TOut> : JLIPNKFLGEL<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct PAPACFBOBDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x553ED00", Offset = "0x553D500", VA = "0x18553ED00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x48CB240", Offset = "0x48C9A40", VA = "0x1848CB240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly GOANNPAHNKI<TIn> GIMHFJHEODH;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> PKNGMGKPCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override KJPDFMLMKLI<TOut> BHCHNLDLDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x63E14A0", Offset = "0x63DFCA0", VA = "0x1863E14A0")]
		public CFALGDAJCCN(GOANNPAHNKI<TIn> HFHFPLADNPC, Func<TIn, TOut> MLDHKINDHNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x63E1100", Offset = "0x63DF900", VA = "0x1863E1100", Slot = "10")]
		protected override void FBKFMPFCODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x63E1320", Offset = "0x63DFB20", VA = "0x1863E1320")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CFALGDAJCCN<, >.PAPACFBOBDM))]
		internal static Task<TOut> ONJJOJABKBH(Task<TIn> LLHLKAAFIAF, Func<TIn, TOut> MLDHKINDHNN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x383ED30", Offset = "0x383D530", VA = "0x18383ED30")]
	public static GOANNPAHNKI<T> HMAILHHHNAA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x383EC80", Offset = "0x383D480", VA = "0x18383EC80")]
	public static GOANNPAHNKI<T> BEIBHKDDCMN<T>(T HLPIAOANGMD, [Optional] Action<T>? HPFEMIAMAPI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90")]
	public static GOANNPAHNKI<T> OIGCKNJMCEL<T>(Exception HNILHIIFGAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90")]
	public static GOANNPAHNKI<T> JBEKCCJJACD<T>(Task<GOANNPAHNKI<T>> BFOIMBMKJIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3530660", Offset = "0x352EE60", VA = "0x183530660")]
	public static GOANNPAHNKI<TOut> FCHHAJKLMDP<TOut, TIn>(GOANNPAHNKI<TIn> EKNJAMPDKID, Func<TIn, TOut> MLDHKINDHNN) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class JLIPNKFLGEL<T> : GOANNPAHNKI<T>, IAIDKAIACPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string DIAOFKIJAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly MBIIGEKJFNE AANEKNOFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool HGKGNONOPPK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xC46E20", Offset = "0xC45620", VA = "0x180C46E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> PKNGMGKPCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract KJPDFMLMKLI<T> BHCHNLDLDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4E28980", Offset = "0x4E27180", VA = "0x184E28980")]
	public JLIPNKFLGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4E28670", Offset = "0x4E26E70", VA = "0x184E28670", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FBKFMPFCODD();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class BMPLGFEOOOC<TTask, T> : JLIPNKFLGEL<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HLHODJFDJJD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public HLHODJFDJJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3FDB4E0", Offset = "0x3FD9CE0", VA = "0x183FDB4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3FDBA30", Offset = "0x3FDA230", VA = "0x183FDBA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public BMPLGFEOOOC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HLHODJFDJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B580", Offset = "0x4A59D80", VA = "0x184A5B580")]
		[AsyncStateMachine(typeof(BMPLGFEOOOC<, >.HLHODJFDJJD.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MADBDFHDOGH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> BFOIMBMKJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource GCOFADJEBOL;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> PKNGMGKPCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override KJPDFMLMKLI<T> BHCHNLDLDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x60129B0", Offset = "0x60111B0", VA = "0x1860129B0")]
	protected BMPLGFEOOOC(TTask BFOIMBMKJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6012760", Offset = "0x6010F60", VA = "0x186012760", Slot = "10")]
	protected override void FBKFMPFCODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CNPDEIBAFOP(TTask IMPHMKOLDHP);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void NGLIAILHNGF();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JAPIEMJNLDN<T> : JLIPNKFLGEL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly JMLHEDJNIFJ<Task<T>> MCHJFDOIFDC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> PKNGMGKPCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4B59120", Offset = "0x4B57920", VA = "0x184B59120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override KJPDFMLMKLI<T> BHCHNLDLDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A3E0", Offset = "0x4D58BE0", VA = "0x184D5A3E0")]
	public JAPIEMJNLDN(JMLHEDJNIFJ<Task<T>> BKAPAFIJEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A3C0", Offset = "0x4D58BC0", VA = "0x184D5A3C0", Slot = "10")]
	protected override void FBKFMPFCODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BOAEELLHNNJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName JPLCNFEFMHD;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> DCKKKNJHHPF;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC7A0", Offset = "0x7AEAFA0", VA = "0x187AEC7A0")]
	public static int LHDPLAGHMLO(this AHFHPLAHONB BOFMAIEJLNL, IncrementalHash EGAIPBFBDLP, byte[] IGGCPMFDLGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC060", Offset = "0x7AEA860", VA = "0x187AEC060")]
	public static bool DBFEADALBMC([CanBeNull] this AHFHPLAHONB BOFMAIEJLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC0C0", Offset = "0x7AEA8C0", VA = "0x187AEC0C0")]
	public static bool DBFEADALBMC([CanBeNull] this AHFHPLAHONB BOFMAIEJLNL, [Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC3D0", Offset = "0x7AEABD0", VA = "0x187AEC3D0")]
	public static bool DBFEADALBMC([CanBeNull] this AHFHPLAHONB BOFMAIEJLNL, IncrementalHash EGAIPBFBDLP, byte[] IGGCPMFDLGC, [Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC710", Offset = "0x7AEAF10", VA = "0x187AEC710")]
	private static bool GHCHAELHGLN(byte[] CCGJIEHLBDL, Span<byte> KENFPNHFAMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EPCOFODLJLM
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDB50", Offset = "0x7AEC350", VA = "0x187AEDB50")]
	public static int HNAIODBMFHO(HashAlgorithmName OMGMOEPEJBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x360E070", Offset = "0x360C870", VA = "0x18360E070")]
	public static int LHDPLAGHMLO<T>(this T CLJEOFLFJGD, byte[] NKEPNDLGENA, IncrementalHash EGAIPBFBDLP, byte[] BBAJBJPJEGL) where T : IMIPDJGBCPB
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface IMIPDJGBCPB
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash EGAIPBFBDLP);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface AHFHPLAHONB : IMIPDJGBCPB
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] AMBEFFLAMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] HAMGGMKMFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class OIFEAMMHPMC
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool IJPJFAAOJBG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> BIIDPJOJHEL;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> KPGHPOBIKGA;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding NEFNKEPMPPH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> KOOPPPMMKFM;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x395EC60", Offset = "0x395D460", VA = "0x18395EC60")]
	public static void AIFILPIAHOI<T>(this IncrementalHash LHMNBALDOPN, [CanBeNull] T IKKBFHNKIMA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x395F240", Offset = "0x395DA40", VA = "0x18395F240")]
	public static void DOKEHABIPEN<T>(this IncrementalHash LHMNBALDOPN, [CanBeNull] T CLJEOFLFJGD) where T : IMIPDJGBCPB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x395ED20", Offset = "0x395D520", VA = "0x18395ED20")]
	public static void DDIGLFJOMPE<T>(this IncrementalHash LHMNBALDOPN, [CanBeNull] IList<T> GHGMADNAKCO) where T : IMIPDJGBCPB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFD60", Offset = "0x7AEE560", VA = "0x187AEFD60")]
	private static bool LPNCPIENCKC([CanBeNull] IMIPDJGBCPB CLJEOFLFJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF260", Offset = "0x7AEDA60", VA = "0x187AEF260")]
	public static void DMAMKLMBFPM(this IncrementalHash EGAIPBFBDLP, string? OCPILIGNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF6C0", Offset = "0x7AEDEC0", VA = "0x187AEF6C0")]
	public static void FCJHPIFFPHN(this IncrementalHash EGAIPBFBDLP, long NOEJKAGJGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF890", Offset = "0x7AEE090", VA = "0x187AEF890")]
	public static void FHIEDIFALML(this IncrementalHash EGAIPBFBDLP, int NKECBGCOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFE50", Offset = "0x7AEE650", VA = "0x187AEFE50")]
	public static void PKNOOBOBBNK(this IncrementalHash EGAIPBFBDLP, short ABIMFHHKEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFAC0", Offset = "0x7AEE2C0", VA = "0x187AEFAC0")]
	public static void GMLPHJMJDMP(this IncrementalHash EGAIPBFBDLP, byte IJFCCOEHENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF0F0", Offset = "0x7AED8F0", VA = "0x187AEF0F0")]
	public static void AGOGFKLKDOC(this IncrementalHash EGAIPBFBDLP, bool FDFPCBKOKFG, bool AMKMBJKDLAP = false, bool HCMLAGPCIOK = false, bool GANCCCGBMMJ = false, bool EDPDIOKLFEA = false, bool JJJFNEMGBBF = false, bool OHAFBLHHHAK = false, bool JEIGCDPKNEO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x395F2D0", Offset = "0x395DAD0", VA = "0x18395F2D0")]
	public static void FGJGAPEKDJM<T>(this IncrementalHash EGAIPBFBDLP, T IPCBOKHNPCP) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFD00", Offset = "0x7AEE500", VA = "0x187AEFD00")]
	public static void JAPHMEONPGO(this IncrementalHash EGAIPBFBDLP, float FGNIEBAIIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF660", Offset = "0x7AEDE60", VA = "0x187AEF660")]
	public static void ENBKDACCOEI(this IncrementalHash EGAIPBFBDLP, ulong EBLKFMGJJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFDF0", Offset = "0x7AEE5F0", VA = "0x187AEFDF0")]
	public static void MFCMBOLJHNC(this IncrementalHash EGAIPBFBDLP, uint HDOKLBMKGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFA60", Offset = "0x7AEE260", VA = "0x187AEFA60")]
	public static void GJLKPNKKKHA(this IncrementalHash EGAIPBFBDLP, ushort AOKEEOEDMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFBD0", Offset = "0x7AEE3D0", VA = "0x187AEFBD0")]
	public static void ILFIDGADDLA(this IncrementalHash EGAIPBFBDLP, Vector3 IEAOEHLPOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IEHFGKKNGOL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE6D0", Offset = "0x7AECED0", VA = "0x187AEE6D0")]
	public IEHFGKKNGOL(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class OIKBFGNHEKE
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void LEHHCDPDAGJ(ushort BHGCFEGNJEJ, ushort HFFEJMKHDOI, ushort MDAKOJOBFGH, ushort MLMABJIBHFB);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void GNMPBGCNDNM(ushort LMNGCBGHLIP, ushort NLHEPKPOLEM);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void LGMEGCOFBLL();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort HAODACLJMDM = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected OIKBFGNHEKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class BNCHADMIJPH<T> : OIKBFGNHEKE where T : BNCHADMIJPH<T>.OPIECCMPLGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface OPIECCMPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		GNMPBGCNDNM MLDEBGMHAEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		GNMPBGCNDNM IECIAOJNNMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		LGMEGCOFBLL CODEBBFCKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> HGDIGIIDHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LGMEGCOFBLL FCJKDLHBHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private LGMEGCOFBLL ODCNLDNMKOA;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PFNNGDFCHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E1B40", Offset = "0x9E0340", VA = "0x1809E1B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort KNNPIMGNLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x60138D0", Offset = "0x60120D0", VA = "0x1860138D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6013D10", Offset = "0x6012510", VA = "0x186013D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort LOJKKFIAGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x60137A0", Offset = "0x6011FA0", VA = "0x1860137A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6013A90", Offset = "0x6012290", VA = "0x186013A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort MFIAIGPIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDA40C0", Offset = "0xDA28C0", VA = "0x180DA40C0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDA41D0", Offset = "0xDA29D0", VA = "0x180DA41D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort JDHDLKFINIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x60136F0", Offset = "0x6011EF0", VA = "0x1860136F0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6013570", Offset = "0x6011D70", VA = "0x186013570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool KEILLAJBJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1757C70", Offset = "0x1756470", VA = "0x181757C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool HCNPBHCJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xE71CC0", Offset = "0xE704C0", VA = "0x180E71CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LEHHCDPDAGJ LGKKOHNKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6013700", Offset = "0x6011F00", VA = "0x186013700")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6012C90", Offset = "0x6011490", VA = "0x186012C90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6013580", Offset = "0x6011D80", VA = "0x186013580")]
	private T DHGLCEKLEEE(ushort MIKMNONCFGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6013630", Offset = "0x6011E30", VA = "0x186013630")]
	private T DPHFCOKOKOK(ushort MIKMNONCFGA, ushort JNEPJLDBFCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6012C20", Offset = "0x6011420", VA = "0x186012C20")]
	protected T AAINPMKKJNP(uint LFPKFIKDFFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6013D20", Offset = "0x6012520", VA = "0x186013D20")]
	protected BNCHADMIJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6013A50", Offset = "0x6012250", VA = "0x186013A50")]
	public void LGLKGLKNLLJ(ushort LADNGFPEEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x60139F0", Offset = "0x60121F0", VA = "0x1860139F0")]
	public void LGLKGLKNLLJ(ushort LADNGFPEEAB, ushort ODPLKHEBPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x60138E0", Offset = "0x60120E0", VA = "0x1860138E0", Slot = "4")]
	protected virtual void LGLKGLKNLLJ(uint GDFKPCOLJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6012D30", Offset = "0x6011530", VA = "0x186012D30")]
	protected void BNIJGLBGEHF(uint GDFKPCOLJIM, uint BMLKGIODFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6013820", Offset = "0x6012020", VA = "0x186013820")]
	protected void JFDDJJJIKIA(ushort MIKMNONCFGA, ushort JNEPJLDBFCP, T LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x60137B0", Offset = "0x6011FB0", VA = "0x1860137B0")]
	private void FAJOCMKJPJJ(uint LFPKFIKDFFM, T LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6013AA0", Offset = "0x60122A0", VA = "0x186013AA0")]
	protected void MPKLABIMGGN(float LMCBAJKHEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6013560", Offset = "0x6011D60", VA = "0x186013560")]
	protected uint CNCELGMEFFM(ushort MIKMNONCFGA, ushort JNEPJLDBFCP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6012C80", Offset = "0x6011480", VA = "0x186012C80")]
	protected ushort AJBBHCOKMED(uint FKDKHMHEHBO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6013810", Offset = "0x6012010", VA = "0x186013810")]
	protected ushort HFACBJIPBLB(uint FKDKHMHEHBO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class FCEONPPDFJN : BNCHADMIJPH<FCEONPPDFJN.MBKKBMLAIAG>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class MBKKBMLAIAG : OPIECCMPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public GNMPBGCNDNM MLDEBGMHAEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public GNMPBGCNDNM IECIAOJNNMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public LGMEGCOFBLL CODEBBFCKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MBKKBMLAIAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDD80", Offset = "0x7AEC580", VA = "0x187AEDD80")]
	public void CJDABGNJKLE(ushort PNLLCNENIOF, GNMPBGCNDNM OKIIPFNMBKM, GNMPBGCNDNM OICFIBABEKL, LGMEGCOFBLL PCEHCDNHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDCA0", Offset = "0x7AEC4A0", VA = "0x187AEDCA0")]
	public void CJDABGNJKLE(ushort MIKMNONCFGA, ushort JNEPJLDBFCP, GNMPBGCNDNM OKIIPFNMBKM, GNMPBGCNDNM OICFIBABEKL, LGMEGCOFBLL PCEHCDNHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDE60", Offset = "0x7AEC660", VA = "0x187AEDE60")]
	public void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDEB0", Offset = "0x7AEC6B0", VA = "0x187AEDEB0")]
	protected FCEONPPDFJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IAJDFJCEOHK : FCEONPPDFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool EKFBLLOBFOA;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool ABPKKBNEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFC1F0", VA = "0x180BFD9F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCC7800", Offset = "0xCC6000", VA = "0x180CC7800")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE610", Offset = "0x7AECE10", VA = "0x187AEE610")]
	public void NPIOKLMMDIH(ushort COJBHNFGFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE670", Offset = "0x7AECE70", VA = "0x187AEE670")]
	public void NPIOKLMMDIH(ushort COJBHNFGFOC, ushort OCLNNGOBGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDEB0", Offset = "0x7AEC6B0", VA = "0x187AEDEB0")]
	public IAJDFJCEOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class LJIDJELCFNP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class NJBFJEIOGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode NFOGFJOGLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode DFPCBMGPBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CPKCKNGFNLC PIDPEOCOGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<CPKCKNGFNLC> DCKCJBOLJOE;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NJBFJEIOGFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct CPKCKNGFNLC : IComparable<CPKCKNGFNLC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int IEAGNNNDKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant NOGGECHCGAO;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1618B10", Offset = "0x1617310", VA = "0x181618B10")]
		public CPKCKNGFNLC(int IEAGNNNDKKH, TClaimant NOGGECHCGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x64E3C90", Offset = "0x64E2490", VA = "0x1864E3C90")]
		public bool OLEBHDGPNIH([In] CPKCKNGFNLC PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x64E3C80", Offset = "0x64E2480", VA = "0x1864E3C80")]
		public bool HHAIIGNINKJ([In] CPKCKNGFNLC PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x64E3C70", Offset = "0x64E2470", VA = "0x1864E3C70", Slot = "4")]
		public int CompareTo(CPKCKNGFNLC PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x64E3CF0", Offset = "0x64E24F0", VA = "0x1864E3CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum KIODOJDOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PKFECIPGOJI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public LJIDJELCFNP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public PKFECIPGOJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5574480", Offset = "0x5572C80", VA = "0x185574480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5574660", Offset = "0x5572E60", VA = "0x185574660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5574560", Offset = "0x5572D60", VA = "0x185574560", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4882120", Offset = "0x4880920", VA = "0x184882120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly OMDHBJNNJHE<NJBFJEIOGFO> EMNCNJODLOO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly OMDHBJNNJHE<List<CPKCKNGFNLC>> EPNOINGMJEO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int CHBIALLHLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> HEKAKLJAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, NJBFJEIOGFO> DHCFHPFPCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private KIODOJDOHOA MGNGIPCHJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode ENELMFFLDAO(TNode GDFCBMOFMFN);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GKFNABBEOCA(TNode GDFCBMOFMFN, TClaimant IFCNOJOAJKE, TClaimant KMDHCADDMEM);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2560", Offset = "0x4FE0D60", VA = "0x184FE2560")]
	public LJIDJELCFNP(KIODOJDOHOA MGNGIPCHJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1470", Offset = "0x4FDFC70", VA = "0x184FE1470")]
	public void KPCHIFBGAPB(TNode GDFCBMOFMFN, TNode GPDOCAJDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0FA0", Offset = "0x4FDF7A0", VA = "0x184FE0FA0")]
	public void IMCMDEJPFCN(TClaimant NOGGECHCGAO, TNode KAGAFFDPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0CB0", Offset = "0x4FDF4B0", VA = "0x184FE0CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1FD0", Offset = "0x4FE07D0", VA = "0x184FE1FD0")]
	private void OPHINHBNMEN(TClaimant NOGGECHCGAO, TNode IOJMCHLPAOP, TNode KAGAFFDPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4FE16B0", Offset = "0x4FDFEB0", VA = "0x184FE16B0")]
	private int MAHKDHFJOCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1120", Offset = "0x4FDF920", VA = "0x184FE1120")]
	private void JGGJMEPPDMH(TClaimant NOGGECHCGAO, TNode CJOFKBCMGIH, TNode LIGGNDMEMHD, int DEOIECBDDBH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1F00", Offset = "0x4FE0700", VA = "0x184FE1F00")]
	private void ONPKKBCCBKK(CPKCKNGFNLC KHMCEHJFAAJ, NJBFJEIOGFO HGAAJHCCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4FE20A0", Offset = "0x4FE08A0", VA = "0x184FE20A0")]
	private void PHFBMAOHOOO(TClaimant NOGGECHCGAO, TNode CJOFKBCMGIH, TNode LIGGNDMEMHD, int DEOIECBDDBH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0B80", Offset = "0x4FDF380", VA = "0x184FE0B80")]
	private void DNOLENPBONG(CPKCKNGFNLC KHMCEHJFAAJ, TNode GDFCBMOFMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1C50", Offset = "0x4FE0450", VA = "0x184FE1C50")]
	private void NABGCKMLKPL(CPKCKNGFNLC KHMCEHJFAAJ, NJBFJEIOGFO HGAAJHCCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1DB0", Offset = "0x4FE05B0", VA = "0x184FE1DB0")]
	private void NNOKCCKCFJB(NJBFJEIOGFO HGAAJHCCLOF, bool JKFFBCBKCML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4FE18E0", Offset = "0x4FE00E0", VA = "0x184FE18E0")]
	private void MELGDIFOEDN(NJBFJEIOGFO HGAAJHCCLOF, TNode GPDOCAJDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0EB0", Offset = "0x4FDF6B0", VA = "0x184FE0EB0")]
	[IteratorStateMachine(typeof(LJIDJELCFNP<, >.PKFECIPGOJI))]
	private IEnumerable<TNode> GCBIJPKBLLP(TNode CJOFKBCMGIH, TNode LIGGNDMEMHD, bool KKOHHONMCDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0A70", Offset = "0x4FDF270", VA = "0x184FE0A70")]
	private NJBFJEIOGFO CNECOLGMJGL(TNode GDFCBMOFMFN, TNode DFPCBMGPBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1530", Offset = "0x4FDFD30", VA = "0x184FE1530")]
	private NJBFJEIOGFO KPIJECIFMNK(TNode GDFCBMOFMFN, TNode DFPCBMGPBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1720", Offset = "0x4FDFF20", VA = "0x184FE1720")]
	private void MBAECNDCJBE(NJBFJEIOGFO HGAAJHCCLOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AEEOJFCDIMH<T> : IEnumerable<AEEOJFCDIMH<T>.LNAFFDMLBGN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct LNAFFDMLBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T OPMIAMEJKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int FPEOONOJHML;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class IFONMJLAEMC : IEnumerator<LNAFFDMLBGN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private AEEOJFCDIMH<T> BGBFHIDBILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int FPEOONOJHML;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4447C70", Offset = "0x4446470", VA = "0x184447C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public LNAFFDMLBGN IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4B709E0", Offset = "0x4B6F1E0", VA = "0x184B709E0", Slot = "4")]
			get
			{
				return default(LNAFFDMLBGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4B708F0", Offset = "0x4B6F0F0", VA = "0x184B708F0")]
		public IFONMJLAEMC(AEEOJFCDIMH<T> BGBFHIDBILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4B707F0", Offset = "0x4B6EFF0", VA = "0x184B707F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x44ACDA0", Offset = "0x44AB5A0", VA = "0x1844ACDA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1118BD0", Offset = "0x11173D0", VA = "0x181118BD0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct PFMJAPBLJAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool PCNHHFMEFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T OPMIAMEJKDH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int FNEHLEIPIOB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> GICCFBHHDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PFMJAPBLJAH[] NJBGMHOKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int JMGAJKGMBGL;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int NMLCPFHHDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3FED240", Offset = "0x3FEBA40", VA = "0x183FED240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4967D30", Offset = "0x4966530", VA = "0x184967D30")]
	public AEEOJFCDIMH(int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4967910", Offset = "0x4966110", VA = "0x184967910")]
	public AEEOJFCDIMH(LNAFFDMLBGN[] JLNCBFPGCIH, bool ELBPPIBGLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4967180", Offset = "0x4965980", VA = "0x184967180")]
	public int FJIAHMIMABJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4967500", Offset = "0x4965D00", VA = "0x184967500")]
	private int IFONKBKACHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4967160", Offset = "0x4965960", VA = "0x184967160", Slot = "6")]
	protected virtual uint CKAKLJODLMD(uint EGAIPBFBDLP, T OPMIAMEJKDH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4967720", Offset = "0x4965F20", VA = "0x184967720")]
	public bool LMPMKEBMPHA(T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x49677F0", Offset = "0x4965FF0", VA = "0x1849677F0")]
	public int OJLHPLKOFMD(T OPMIAMEJKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4967780", Offset = "0x4965F80", VA = "0x184967780")]
	public T NJJMECDNEFH(int FPEOONOJHML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4967240", Offset = "0x4965A40", VA = "0x184967240")]
	public bool HBGAGBEBOKC(T OPMIAMEJKDH, bool IFMILMMHKHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x49672A0", Offset = "0x4965AA0", VA = "0x1849672A0")]
	public bool HBGAGBEBOKC(T OPMIAMEJKDH, int FPEOONOJHML, bool IFMILMMHKHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4967110", Offset = "0x4965910", VA = "0x184967110")]
	private int AAJJCFHJPDP(int IFOFOJHAFEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4967870", Offset = "0x4966070", VA = "0x184967870", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4967870", Offset = "0x4966070", VA = "0x184967870", Slot = "4")]
	private IEnumerator<LNAFFDMLBGN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class OMDHBJNNJHE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> BODBBJKKCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> BJMHMPGKEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int CCIJABCBAKP;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x547EED0", Offset = "0x547D6D0", VA = "0x18547EED0")]
	public static OMDHBJNNJHE<T> HNBKMDKFNME(int CFHPBCCHEDC = 0, int CCIJABCBAKP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x547E980", Offset = "0x547D180", VA = "0x18547E980")]
	public static OMDHBJNNJHE<T> CBFGIBCJILG(int CFHPBCCHEDC = 0, int CCIJABCBAKP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x547F4E0", Offset = "0x547DCE0", VA = "0x18547F4E0")]
	public OMDHBJNNJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x547F2D0", Offset = "0x547DAD0", VA = "0x18547F2D0")]
	public OMDHBJNNJHE(int CFHPBCCHEDC, int CCIJABCBAKP = int.MaxValue, bool PIJPNCPKCOP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x547EC00", Offset = "0x547D400", VA = "0x18547EC00")]
	public T GDNGJAGCHOI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x547EFC0", Offset = "0x547D7C0", VA = "0x18547EFC0")]
	public void IHLFGIKCBJJ(T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x547EDD0", Offset = "0x547D5D0", VA = "0x18547EDD0")]
	private void HDEPELCHKKE(T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x547F290", Offset = "0x547DA90", VA = "0x18547F290")]
	private void LAPBALPDHOM(T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x547EA70", Offset = "0x547D270", VA = "0x18547EA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x547F0A0", Offset = "0x547D8A0", VA = "0x18547F0A0")]
	private void IIJDEKGCJGC(IEnumerable<T> MGEDIIGJIGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LEODEGJFDPN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> BFIDNFGDLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T BKBECPENAHL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T JGELKDHDBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC2E0", Offset = "0x4FDAAE0", VA = "0x184FDC2E0")]
	public bool DDFDIJPBPID(T OPMIAMEJKDH, int IEAGNNNDKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4980070", Offset = "0x497E870", VA = "0x184980070")]
	public bool LABBPGFDNPL(int IEAGNNNDKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC380", Offset = "0x4FDAB80", VA = "0x184FDC380")]
	public T MKENFGMFOPF(int ILNLBJJLPBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC0B0", Offset = "0x4FDA8B0", VA = "0x184FDC0B0")]
	private bool CBKFJIKNJLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC050", Offset = "0x4FDA850", VA = "0x184FDC050")]
	public bool AEJGKIILIJC(int IEAGNNNDKKH, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4980170", Offset = "0x497E970", VA = "0x184980170")]
	public LEODEGJFDPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KPPIPKOCDJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct LALEGPIEEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T GDCDOMLHCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MLANLEIGIEB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<LALEGPIEEKI> MLOHNMJPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T JAGCCCLNDME;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3FED240", Offset = "0x3FEBA40", VA = "0x183FED240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4F52270", Offset = "0x4F50A70", VA = "0x184F52270")]
	public bool PHEIEKKHJKM(T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4F51FB0", Offset = "0x4F507B0", VA = "0x184F51FB0")]
	public void OIHLAKEIFNH(T OPMIAMEJKDH, int IEAGNNNDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4F51A90", Offset = "0x4F50290", VA = "0x184F51A90")]
	public bool AHELLINFOCL(T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4F51F10", Offset = "0x4F50710", VA = "0x184F51F10")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4F521E0", Offset = "0x4F509E0", VA = "0x184F521E0")]
	public T PFICPHCHOIO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4F51D90", Offset = "0x4F50590", VA = "0x184F51D90")]
	protected void DHKPLPAIGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4F52660", Offset = "0x4F50E60", VA = "0x184F52660")]
	public KPPIPKOCDJJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7AF03C0", Offset = "0x7AEEBC0", VA = "0x187AF03C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF0690", Offset = "0x7AEEE90", VA = "0x187AF0690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF05A0", Offset = "0x7AEEDA0", VA = "0x187AF05A0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7AF0310", Offset = "0x7AEEB10", VA = "0x187AF0310")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7AF05E0", Offset = "0x7AEEDE0", VA = "0x187AF05E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7AF04F0", Offset = "0x7AEECF0", VA = "0x187AF04F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0290", Offset = "0x7AEEA90", VA = "0x187AF0290")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x575B580", Offset = "0x5759D80", VA = "0x18575B580", Slot = "4")]
		public virtual T IPJJBNGCHLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DPFAPPKAMBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, FNKAOKGCAJP> KIOAEEENFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly OMDHBJNNJHE<FNKAOKGCAJP> IIGOFHGELDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool NOEHPPEDEIN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FNKAOKGCAJP LNMNPBFOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 PKFIGNAMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1594000", Offset = "0x1592800", VA = "0x181594000")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 LKGCEDCMEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 KEPPKKPIPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7AECB00", Offset = "0x7AEB300", VA = "0x187AECB00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DE0", Offset = "0x9DF5E0", VA = "0x1809E0DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int ELOEIEBBNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDA90", Offset = "0x7AEC290", VA = "0x187AEDA90")]
	public DPFAPPKAMBD(Bounds LOADFKJKAEI, Vector2[] FDMCLCNBABK, int OGKMMGIPMEG, byte IFOFOJHAFEG, float ODPLNCDJEOI = 0f, [Optional] OMDHBJNNJHE<FNKAOKGCAJP> IIGOFHGELDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7AED080", Offset = "0x7AEB880", VA = "0x187AED080")]
	public void JDAPDHGLBFN(Bounds LOADFKJKAEI, Vector2[] FDMCLCNBABK, int OGKMMGIPMEG, byte IFOFOJHAFEG, float ODPLNCDJEOI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7AED960", Offset = "0x7AEC160", VA = "0x187AED960")]
	public FNKAOKGCAJP OGBJHJGGCJH(byte FPEOONOJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7AED9C0", Offset = "0x7AEC1C0", VA = "0x187AED9C0")]
	public void PEDGIBOEJAM(Vector3 NCGKJMOKFAF, float ALPKJFDAJDC, float AOCPDCNBLGC, List<byte> FMEJCNCEDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7AECAE0", Offset = "0x7AEB2E0", VA = "0x187AECAE0")]
	public void AJIOCCDJKOM(FNKAOKGCAJP.MNCHENJCBAK LAMMCDFODDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7AECB20", Offset = "0x7AEB320", VA = "0x187AECB20")]
	public static int CABMFGOCPPN(Vector2[] FDMCLCNBABK, int OGKMMGIPMEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7AED510", Offset = "0x7AEBD10", VA = "0x187AED510")]
	private FNKAOKGCAJP KEOIOBAJLKB(byte FPEOONOJHML, FNKAOKGCAJP.HEOIBAFCKDN GFNOOLIJFJH, FNKAOKGCAJP DFPCBMGPBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7AECCC0", Offset = "0x7AEB4C0", VA = "0x187AECCC0")]
	private void HLDAJJKOBED(FNKAOKGCAJP DFPCBMGPBFO, Vector2[] FDMCLCNBABK, int HCLLILMNPMK, int NDMKFKCPGMA, int CIGAGFBDBPE, int DEJFHJNLHEK, float ODPLNCDJEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7AED740", Offset = "0x7AEBF40", VA = "0x187AED740")]
	private void LBBIFLPFFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7AECC00", Offset = "0x7AEB400", VA = "0x187AECC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7AECC60", Offset = "0x7AEB460", VA = "0x187AECC60", Slot = "1")]
	~DPFAPPKAMBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FNKAOKGCAJP
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum HEOIBAFCKDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum MNCHENJCBAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte NGHJMEDCGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 GBEKDLEJDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 OABHEPHNFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 ELGAFFHINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 CEGIPJGFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public HEOIBAFCKDN JKPCNBOMBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public FNKAOKGCAJP BKMKKMCIDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<FNKAOKGCAJP> PGLNGFOOGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool FMDMHOCNNFK;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE480", Offset = "0x7AECC80", VA = "0x187AEE480")]
	public FNKAOKGCAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE020", Offset = "0x7AEC820", VA = "0x187AEE020")]
	public void JFLMNIPCHGD(FNKAOKGCAJP NGDINOANFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public void AJIOCCDJKOM(int JGOPCKLIFKB, MNCHENJCBAK LAMMCDFODDN, int LEIIPDHBCHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE220", Offset = "0x7AECA20", VA = "0x187AEE220")]
	public void PEDGIBOEJAM(List<byte> FMEJCNCEDKC, Vector3 NCGKJMOKFAF, float ALPKJFDAJDC, float AOCPDCNBLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE160", Offset = "0x7AEC960", VA = "0x187AEE160")]
	public bool KJDPFOGLPHI(Vector3 AJNIOMMLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDFF0", Offset = "0x7AEC7F0", VA = "0x187AEDFF0")]
	public bool JAOGKFKKKOP(Vector3 AJNIOMMLJNB, float BNIMBFFENPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE190", Offset = "0x7AEC990", VA = "0x187AEE190")]
	public void NPIOKLMMDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface BKNKGCCNPCG
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache PINPPHKIDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct JKNFPFMLPAE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> GIPAMJGJGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool OPOHOHGAKHH;

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1774470", Offset = "0x1772C70", VA = "0x181774470")]
			public JKNFPFMLPAE(List<Component> GIPAMJGJGNH, bool OPOHOHGAKHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x4DC8890", Offset = "0x4DC7090", VA = "0x184DC8890")]
			public IACPIAIGMNP<T> DPNIJJHCOGM()
			{
				return default(IACPIAIGMNP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x4DC88F0", Offset = "0x4DC70F0", VA = "0x184DC88F0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4DC88F0", Offset = "0x4DC70F0", VA = "0x184DC88F0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public struct IACPIAIGMNP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> GIPAMJGJGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool OPOHOHGAKHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int FPEOONOJHML;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T IECKFCICFIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4B49070", Offset = "0x4B47870", VA = "0x184B49070", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x4B49000", Offset = "0x4B47800", VA = "0x184B49000", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x4B49040", Offset = "0x4B47840", VA = "0x184B49040")]
			public IACPIAIGMNP(List<Component> GIPAMJGJGNH, bool OPOHOHGAKHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4B48F40", Offset = "0x4B47740", VA = "0x184B48F40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x4B48F50", Offset = "0x4B47750", VA = "0x184B48F50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x449D9C0", Offset = "0x449C1C0", VA = "0x18449D9C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7AF2080", Offset = "0x7AF0880", VA = "0x187AF2080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1E70", Offset = "0x7AF0670", VA = "0x187AF1E70")]
		private void NPIOKLMMDIH(GameObject LCCMOEPNGNG, bool IOHDICMKADP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1DE0", Offset = "0x7AF05E0", VA = "0x187AF1DE0")]
		public static void NPIOKLMMDIH(GameObject LCCMOEPNGNG, ToolHierarchyCache JCIIFEEGFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1FE0", Offset = "0x7AF07E0", VA = "0x187AF1FE0")]
		public void OHNEMOLKICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3B11980", Offset = "0x3B10180", VA = "0x183B11980")]
		public void DFCJJPHCKME<T>(Action<T> GFMBHCHPLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3B11BC0", Offset = "0x3B103C0", VA = "0x183B11BC0")]
		public T MAJKPNCCMLJ<T>(bool OPOHOHGAKHH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3B118C0", Offset = "0x3B100C0", VA = "0x183B118C0")]
		public JKNFPFMLPAE<T> CIOLBDPBJBP<T>(bool OPOHOHGAKHH = false) where T : class
		{
			return default(JKNFPFMLPAE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7AF19F0", Offset = "0x7AF01F0", VA = "0x187AF19F0")]
		public List<Component> GHGKKFJJLFP(Type PIJHKCJDAHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1970", Offset = "0x7AF0170", VA = "0x187AF1970", Slot = "4")]
		public bool Equals(ToolHierarchyCache LEFBJAGNHCD, ToolHierarchyCache LLGPJHIECFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1D70", Offset = "0x7AF0570", VA = "0x187AF1D70", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PNHCNFOFAFI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class JIDBIICPPDJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CFHPBCCHEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int JCPGJOAGLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> FBJFJEKNKKG;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4B59120", Offset = "0x4B57920", VA = "0x184B59120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T BMGLGMIMDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1EF0", Offset = "0x4DA06F0", VA = "0x184DA1EF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T FKNBPGMNJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4DA23A0", Offset = "0x4DA0BA0", VA = "0x184DA23A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T CPKOACIPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4DA2110", Offset = "0x4DA0910", VA = "0x184DA2110")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA27D0", Offset = "0x4DA0FD0", VA = "0x184DA27D0")]
	public JIDBIICPPDJ(int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4DA25F0", Offset = "0x4DA0DF0", VA = "0x184DA25F0")]
	public void OIHLAKEIFNH(T FOJNEGDPDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA2440", Offset = "0x4DA0C40", VA = "0x184DA2440")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA21B0", Offset = "0x4DA09B0", VA = "0x184DA21B0")]
	public void DOIGKMAJNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA2760", Offset = "0x4DA0F60", VA = "0x184DA2760")]
	public void OODAJANBCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4DA27C0", Offset = "0x4DA0FC0", VA = "0x184DA27C0")]
	public void OPFKLAPIJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4DA22A0", Offset = "0x4DA0AA0", VA = "0x184DA22A0")]
	public List<T> FGBHAIABCHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class KPIDBFOJEAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct APDEMCDALBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int MLANLEIGIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T GDCDOMLHCOE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, APDEMCDALBA> BFIDNFGDLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> DAOLMDAGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T BKBECPENAHL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T JGELKDHDBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCF73C0", Offset = "0xCF5BC0", VA = "0x180CF73C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4F50230", Offset = "0x4F4EA30", VA = "0x184F50230", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool NDKPBGECEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x4F50310", Offset = "0x4F4EB10", VA = "0x184F50310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object EMIOGMEDFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4F4F630", Offset = "0x4F4DE30", VA = "0x184F4F630")]
	public bool DDFDIJPBPID(T OPMIAMEJKDH, object JILOCOLKOMJ, int IEAGNNNDKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4F50250", Offset = "0x4F4EA50", VA = "0x184F50250")]
	public bool LABBPGFDNPL(object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C380", Offset = "0x4F4AB80", VA = "0x184F4C380")]
	public bool AEJGKIILIJC(object JILOCOLKOMJ, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4F503A0", Offset = "0x4F4EBA0", VA = "0x184F503A0")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4F4CA90", Offset = "0x4F4B290", VA = "0x184F4CA90")]
	private bool CBKFJIKNJLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4F503F0", Offset = "0x4F4EBF0", VA = "0x184F503F0")]
	public KPIDBFOJEAM()
	{
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
