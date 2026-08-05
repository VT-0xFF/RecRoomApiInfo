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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8130C60", Offset = "0x812FC60", VA = "0x188130C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INHMCOGALFI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
	public INHMCOGALFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, AJIJOGMEBDH, EILONDPOBCI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash EGEGACCNNEK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
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
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8132940", Offset = "0x8131940", VA = "0x188132940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8132900", Offset = "0x8131900", VA = "0x188132900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8132980", Offset = "0x8131980", VA = "0x188132980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8132B30", Offset = "0x8131B30", VA = "0x188132B30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8132AA0", Offset = "0x8131AA0", VA = "0x188132AA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xABF1F0", Offset = "0xABE1F0", VA = "0x180ABF1F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xABF200", Offset = "0xABE200", VA = "0x180ABF200")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81328C0", Offset = "0x81318C0", VA = "0x1881328C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8132A10", Offset = "0x8131A10", VA = "0x188132A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8132420", Offset = "0x8131420", VA = "0x188132420")]
	public void CopyBounds(SavedExtents EDJHHGMLKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8132810", Offset = "0x8131810", VA = "0x188132810")]
	public void SetLocalSpaceBounds(Bounds PMFMBMHGBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16626A0", Offset = "0x16616A0", VA = "0x1816626A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8132800", Offset = "0x8131800", VA = "0x188132800")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8132450", Offset = "0x8131450", VA = "0x188132450")]
	private void HBAPNNBPDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8132600", Offset = "0x8131600", VA = "0x188132600")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8131DB0", Offset = "0x8130DB0", VA = "0x188131DB0")]
	public static void CalculateLocalBoundsFor(GameObject GLGAAAMILBJ, [Out] Bounds PMFMBMHGBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8131CF0", Offset = "0x8130CF0", VA = "0x188131CF0")]
	private static void AELOKOACBFJ(Bounds LDPKBPICKKH, Color JKODNDABGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8132830", Offset = "0x8131830", VA = "0x188132830")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F290", Offset = "0x1B1E290", VA = "0x181B1F290")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B380", Offset = "0x5C9A380", VA = "0x185C9B380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public virtual void IGNFIIDFFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
	[INHMCOGALFI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C9AFB0", Offset = "0x5C99FB0", VA = "0x185C9AFB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C99E00", Offset = "0x5C98E00", VA = "0x185C99E00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B2E0", Offset = "0x5C9A2E0", VA = "0x185C9B2E0")]
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
	private sealed class GMMDIJFGKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GMMDIJFGKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5070", Offset = "0x4ED4070", VA = "0x184ED5070")]
		internal int MDBDFBIJLGC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[INHMCOGALFI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x492E160", Offset = "0x492D160", VA = "0x18492E160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x492E1A0", Offset = "0x492D1A0", VA = "0x18492E1A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x492E080", Offset = "0x492D080", VA = "0x18492E080", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey DAKIIEIEKNI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x492E100", Offset = "0x492D100", VA = "0x18492E100", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x492DF80", Offset = "0x492CF80", VA = "0x18492DF80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x492DCA0", Offset = "0x492CCA0", VA = "0x18492DCA0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x492D190", Offset = "0x492C190", VA = "0x18492D190", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x492D100", Offset = "0x492C100", VA = "0x18492D100", Slot = "14")]
	protected virtual string NMLKIFMBKEE(TKeyVal EKBAEMLNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x492D020", Offset = "0x492C020", VA = "0x18492D020", Slot = "4")]
	public bool ContainsKey(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x492DE50", Offset = "0x492CE50", VA = "0x18492DE50", Slot = "5")]
	public bool TryGetValue(TKey DAKIIEIEKNI, [Out] TVal IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x492D060", Offset = "0x492C060", VA = "0x18492D060", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x492D060", Offset = "0x492C060", VA = "0x18492D060", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x492DE90", Offset = "0x492CE90", VA = "0x18492DE90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
		[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[INHMCOGALFI]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C9CA20", Offset = "0x5C9BA20", VA = "0x185C9CA20")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C370", Offset = "0x5C9B370", VA = "0x185C9C370", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B9F0", Offset = "0x5C9A9F0", VA = "0x185C9B9F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NLHOLOPGBPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JKKFFFANMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T BDJLGAHJNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float FLHJHIDFNFH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int NCPOHBNCGFP = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float HKOJGLBILIC = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly JKKFFFANMAJ[] MFIJBPNIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int LHGIONEHLAB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float OAMMEAFGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD356F0", Offset = "0xD346F0", VA = "0x180D356F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDA03A0", Offset = "0xD9F3A0", VA = "0x180DA03A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T DOMMDAJHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5798450", Offset = "0x5797450", VA = "0x185798450")]
	protected NLHOLOPGBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5798470", Offset = "0x5797470", VA = "0x185798470")]
	protected NLHOLOPGBPJ(int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57982A0", Offset = "0x57972A0", VA = "0x1857982A0")]
	public void DOPEKGIEJEC(float JAPNNLNNKKI, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MKEEGMGOLIA(float NBMPCLDEACH, float EPGMGAHKPKO, [Out] T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool IOBFFIILLAK(float NBMPCLDEACH, float EPGMGAHKPKO, [Out] T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x57983F0", Offset = "0x57973F0", VA = "0x1857983F0")]
	public void JPJFAMEFLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ADKENPBDLBE : NLHOLOPGBPJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x812EA90", Offset = "0x812DA90", VA = "0x18812EA90", Slot = "4")]
	public override bool MKEEGMGOLIA(float NBMPCLDEACH, float EPGMGAHKPKO, [Out] Vector3 IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x812E950", Offset = "0x812D950", VA = "0x18812E950", Slot = "5")]
	public override bool IOBFFIILLAK(float NBMPCLDEACH, float EPGMGAHKPKO, [Out] Vector3 IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x812EBF0", Offset = "0x812DBF0", VA = "0x18812EBF0")]
	public ADKENPBDLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MBEGLDBDMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D77600", Offset = "0x3D76600", VA = "0x183D77600")]
	public static OGHBOJKPEKD<T1, T2> MEFBGKEPBLF<T1, T2>(T1 LDDCBCOLCMN, T2 JDOKPLBIOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D77680", Offset = "0x3D76680", VA = "0x183D77680")]
	public static HDLJFKPHMEI<T1, T2, T3> MEFBGKEPBLF<T1, T2, T3>(T1 LDDCBCOLCMN, T2 JDOKPLBIOHA, T3 CILMILCKNNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5742500", Offset = "0x5741500", VA = "0x185742500")]
	internal static int GPHFGNKPNLE(int OADDBHKMKGA, int NJKNBMBIHLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72B80F0", Offset = "0x72B70F0", VA = "0x1872B80F0")]
	internal static int GPHFGNKPNLE(int OADDBHKMKGA, int NJKNBMBIHLI, int CFOBLHHBAIP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OGHBOJKPEKD<T1, T2> : IComparable<OGHBOJKPEKD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 BDJDAENICLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 JIBIPONMMFC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x58AE650", Offset = "0x58AD650", VA = "0x1858AE650")]
	public OGHBOJKPEKD(T1 LDDCBCOLCMN, T2 JDOKPLBIOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x58AD630", Offset = "0x58AC630", VA = "0x1858AD630", Slot = "4")]
	public int CompareTo(OGHBOJKPEKD<T1, T2> EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x58AD710", Offset = "0x58AC710", VA = "0x1858AD710", Slot = "0")]
	public override bool Equals(object EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x58ADF50", Offset = "0x58ACF50", VA = "0x1858ADF50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x58AE160", Offset = "0x58AD160", VA = "0x1858AE160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HDLJFKPHMEI<T1, T2, T3> : IComparable<HDLJFKPHMEI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 BDJDAENICLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 JIBIPONMMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 BPCJKLOIMMH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F35EF0", Offset = "0x4F34EF0", VA = "0x184F35EF0")]
	public HDLJFKPHMEI(T1 LDDCBCOLCMN, T2 JDOKPLBIOHA, T3 CILMILCKNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F355D0", Offset = "0x4F345D0", VA = "0x184F355D0", Slot = "4")]
	public int CompareTo(HDLJFKPHMEI<T1, T2, T3> EDJHHGMLKFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F35830", Offset = "0x4F34830", VA = "0x184F35830", Slot = "0")]
	public override bool Equals(object EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4F35B00", Offset = "0x4F34B00", VA = "0x184F35B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F35D40", Offset = "0x4F34D40", VA = "0x184F35D40", Slot = "3")]
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
	public AnimationCurve IOGNHJAFMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NNMLLFNMFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HDKDNJDPMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2E69230", Offset = "0x2E68230", VA = "0x182E69230")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2E690E0", Offset = "0x2E680E0", VA = "0x182E690E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float BJIMIPGDEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAB2F30", Offset = "0xAB1F30", VA = "0x180AB2F30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F531C0", Offset = "0x5F521C0", VA = "0x185F531C0")]
	public T FKGCDJJLNKL(float HBPDACJCCKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F53480", Offset = "0x5F52480", VA = "0x185F53480")]
	public T HKPLHBLBPLI(float HBPDACJCCKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HLBHONJOHFN(T MLCJFBKFHOP, T FPNPAOBAPAE, float HBPDACJCCKM);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8130390", Offset = "0x812F390", VA = "0x188130390", Slot = "4")]
	protected override float HLBHONJOHFN(float MLCJFBKFHOP, float FPNPAOBAPAE, float HBPDACJCCKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x81303D0", Offset = "0x812F3D0", VA = "0x1881303D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x197C610", Offset = "0x197B610", VA = "0x18197C610", Slot = "4")]
	protected override Vector3 HLBHONJOHFN(Vector3 MLCJFBKFHOP, Vector3 FPNPAOBAPAE, float HBPDACJCCKM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8133980", Offset = "0x8132980", VA = "0x188133980")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x812FFC0", Offset = "0x812EFC0", VA = "0x18812FFC0", Slot = "4")]
	protected override Color HLBHONJOHFN(Color MLCJFBKFHOP, Color FPNPAOBAPAE, float HBPDACJCCKM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8130080", Offset = "0x812F080", VA = "0x188130080")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BFMJJMKMFOC : MMBBJBBHGFF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x812FF70", Offset = "0x812EF70", VA = "0x18812FF70")]
	public BFMJJMKMFOC(int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x812FF00", Offset = "0x812EF00", VA = "0x18812FF00", Slot = "6")]
	protected override uint FJHDCEKFIJE(uint EGEGACCNNEK, string IOALKPFEKEK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DFHKELHBNCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DFHKELHBNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CBLHGGLBPJF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FKLNEFAIPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int GFAKOONFACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int CHMOGPKHCDA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x48E9230", Offset = "0x48E8230", VA = "0x1848E9230")]
	private CBLHGGLBPJF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IFGNMHIGMNC, int CHIKDJAEFGA, int AGMCJLJPKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68AA0E0", Offset = "0x68A90E0", VA = "0x1868AA0E0")]
	public static CBLHGGLBPJF<T> MPFKOOIPONO()
	{
		return default(CBLHGGLBPJF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68A8040", Offset = "0x68A7040", VA = "0x1868A8040")]
	public (int, int, Task<T>) FIBHAGNDADL(int NFDMOMMJDAE, [Optional] CancellationToken KGALDHLEDNC, double GLANCCCAPLO = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68A9D90", Offset = "0x68A8D90", VA = "0x1868A9D90")]
	public void FNJFGPKFIHJ(int NFDMOMMJDAE, int AGMCJLJPKKI, [In] T BGOCMPMGKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DLBDOKHEFGO
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81301C0", Offset = "0x812F1C0", VA = "0x1881301C0")]
	public static CBLHGGLBPJF<GAAICFLNCNK> MPFKOOIPONO()
	{
		return default(CBLHGGLBPJF<GAAICFLNCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8130140", Offset = "0x812F140", VA = "0x188130140")]
	public static void FNJFGPKFIHJ([In] this CBLHGGLBPJF<GAAICFLNCNK> OLHDOIOOPGE, int NFDMOMMJDAE, int AGMCJLJPKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class MBMCNGKDFPF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> ACNFMOLIMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> KAGCJDELDHP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4474990", Offset = "0x4473990", VA = "0x184474990", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool COBLKMLKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> MEHKDENMJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x568CFC0", Offset = "0x568BFC0", VA = "0x18568CFC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> JDDHHJMKIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5697780", Offset = "0x5696780", VA = "0x185697780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5697720", Offset = "0x5696720", VA = "0x185697720", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56977C0", Offset = "0x56967C0", VA = "0x1856977C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5696FD0", Offset = "0x5695FD0", VA = "0x185696FD0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5696E60", Offset = "0x5695E60", VA = "0x185696E60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56975A0", Offset = "0x56965A0", VA = "0x1856975A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5696D50", Offset = "0x5695D50", VA = "0x185696D50", Slot = "9")]
	public void Add(TKey DAKIIEIEKNI, TVal IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5696DA0", Offset = "0x5695DA0", VA = "0x185696DA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5696EC0", Offset = "0x5695EC0", VA = "0x185696EC0", Slot = "8")]
	public bool ContainsKey(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5696F00", Offset = "0x5695F00", VA = "0x185696F00", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5697530", Offset = "0x5696530", VA = "0x185697530", Slot = "10")]
	public bool Remove(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56974D0", Offset = "0x56964D0", VA = "0x1856974D0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x56975F0", Offset = "0x56965F0", VA = "0x1856975F0", Slot = "11")]
	public bool TryGetValue(TKey DAKIIEIEKNI, [Out] TVal IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5697200", Offset = "0x5696200", VA = "0x185697200", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5696F60", Offset = "0x5695F60", VA = "0x185696F60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MFIJBPNIELL, int EFMHKDAINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5696DD0", Offset = "0x5695DD0", VA = "0x185696DD0")]
	public bool BOIPBPENDNC(TVal DAKIIEIEKNI, [Out] TKey IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x56973B0", Offset = "0x56963B0", VA = "0x1856973B0")]
	private void MBFHEJCPLGF(TKey DAKIIEIEKNI, TVal GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5697310", Offset = "0x5696310", VA = "0x185697310")]
	private void LKOKFKDKBJO(TKey DAKIIEIEKNI, TVal GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5697060", Offset = "0x5696060", VA = "0x185697060")]
	private bool FAIOGBIGEIC(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5697630", Offset = "0x5696630", VA = "0x185697630")]
	public MBMCNGKDFPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class ABNEAEFNHOE<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ABNEAEFNHOE<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4988400", Offset = "0x4987400", VA = "0x184988400", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x49911B0", Offset = "0x49901B0", VA = "0x1849911B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4992990", Offset = "0x4991990", VA = "0x184992990")]
		public Enumerator(ABNEAEFNHOE<T> MPPMMFHHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x498F7F0", Offset = "0x498E7F0", VA = "0x18498F7F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x49904B0", Offset = "0x498F4B0", VA = "0x1849904B0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x498E900", Offset = "0x498D900", VA = "0x18498E900")]
		private void FJBBDJIMLOO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] CJKBEHPOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int OBJODNIPNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int OLJOGIAEFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LMOHNMMFGMP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x50C8300", Offset = "0x50C7300", VA = "0x1850C8300", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50C6E60", Offset = "0x50C5E60", VA = "0x1850C6E60")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x50C7D30", Offset = "0x50C6D30", VA = "0x1850C7D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x50C8280", Offset = "0x50C7280", VA = "0x1850C8280")]
	public ABNEAEFNHOE(int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x50C7080", Offset = "0x50C6080", VA = "0x1850C7080")]
	public void DOPEKGIEJEC(T HBPDACJCCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x50C5DD0", Offset = "0x50C4DD0", VA = "0x1850C5DD0")]
	public void ADIOIPAEJCH(IEnumerable<T> GHPPGCHDHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x50C76A0", Offset = "0x50C66A0", VA = "0x1850C76A0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x50C7600", Offset = "0x50C6600", VA = "0x1850C7600")]
	public void HCDFAPECPPG(int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x50C6610", Offset = "0x50C5610", VA = "0x1850C6610")]
	public void CNNAEIEFJDJ(T[] MFIJBPNIELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x50C7520", Offset = "0x50C6520", VA = "0x1850C7520")]
	public Enumerator GHDHEBFDHCI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x50C80C0", Offset = "0x50C70C0", VA = "0x1850C80C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50C80C0", Offset = "0x50C70C0", VA = "0x1850C80C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50C79C0", Offset = "0x50C69C0", VA = "0x1850C79C0")]
	private int MPBLDGIICDK(int HLGKMAPOEBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50C74C0", Offset = "0x50C64C0", VA = "0x1850C74C0")]
	private int EENOJFODJGH(int HLGKMAPOEBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IGOEDOBPDOB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> LLNPPBBBAPP(TRequest LIPNPCINFLG, CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum GNHMKHAMAAG
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AIPFCPOHPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float BENCCEKIFJE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan JLMFOLNKHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int KGDIHLMINLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GNHMKHAMAAG HEJFIPHPBEM;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly AIPFCPOHPGJ HPFHFAKCNGM;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float HDOJAOJOAHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x519DDF0", Offset = "0x519CDF0", VA = "0x18519DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan HMCHJDCANLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x519E020", Offset = "0x519D020", VA = "0x18519E020")]
		public AIPFCPOHPGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct DCELEGAIAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest LIPNPCINFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken KGALDHLEDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> JNDCEEEHCNL;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E7DEB0", Offset = "0x6E7CEB0", VA = "0x186E7DEB0")]
		public DCELEGAIAGC(TRequest LIPNPCINFLG, TaskCompletionSource<TResult> JNDCEEEHCNL, CancellationToken KGALDHLEDNC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct NCFFJCLFMPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IGOEDOBPDOB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5778BD0", Offset = "0x5777BD0", VA = "0x185778BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5778F90", Offset = "0x5777F90", VA = "0x185778F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct ADHMKBBJHJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IGOEDOBPDOB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private DCELEGAIAGC <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x50CF190", Offset = "0x50CE190", VA = "0x1850CF190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x50CF770", Offset = "0x50CE770", VA = "0x1850CF770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource MLGLIOHGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<DCELEGAIAGC> LKBBGLDDDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly AIPFCPOHPGJ KEINGPNKNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LLNPPBBBAPP IMHCKAFLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task NCDHNMDDGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int IKPBIEOHMMM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x501BDA0", Offset = "0x501ADA0", VA = "0x18501BDA0")]
	public IGOEDOBPDOB(LLNPPBBBAPP IMHCKAFLGCI, [Optional] AIPFCPOHPGJ KEINGPNKNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x501A9A0", Offset = "0x50199A0", VA = "0x18501A9A0")]
	public Task<TResult> DJIOKMKBIKP(TRequest LIPNPCINFLG, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x501AEE0", Offset = "0x5019EE0", VA = "0x18501AEE0")]
	private void HMPNJMNFHEB(DCELEGAIAGC DEMGBFNPMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x501AF70", Offset = "0x5019F70", VA = "0x18501AF70")]
	[AsyncStateMachine(typeof(IGOEDOBPDOB<, >.NCFFJCLFMPG))]
	private Task JFKJLILIPMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x501B6E0", Offset = "0x501A6E0", VA = "0x18501B6E0")]
	private DCELEGAIAGC MDHEPPPOFAI()
	{
		return default(DCELEGAIAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x501BB40", Offset = "0x501AB40", VA = "0x18501BB40")]
	[AsyncStateMachine(typeof(IGOEDOBPDOB<, >.ADHMKBBJHJL))]
	private Task PMGENDNCOMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x501A680", Offset = "0x5019680", VA = "0x18501A680")]
	private void ANJGJIFMOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x501AD60", Offset = "0x5019D60", VA = "0x18501AD60", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class AMABHBOHMCE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> KKAPDLIJLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> EHICPLDBEEF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4474990", Offset = "0x4473990", VA = "0x184474990", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool COBLKMLKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5270960", Offset = "0x526F960", VA = "0x185270960", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x52709A0", Offset = "0x526F9A0", VA = "0x1852709A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0950", Offset = "0x4DDF950", VA = "0x184DE0950", Slot = "11")]
	public void Add(T ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5270430", Offset = "0x526F430", VA = "0x185270430")]
	public bool OGAMCDIANIG(T ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x52707E0", Offset = "0x526F7E0", VA = "0x1852707E0", Slot = "15")]
	public bool Remove(T ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B520", Offset = "0x4E4A520", VA = "0x184E4B520", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4ED93D0", Offset = "0x4ED83D0", VA = "0x184ED93D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5270180", Offset = "0x526F180", VA = "0x185270180", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x52701E0", Offset = "0x526F1E0", VA = "0x1852701E0", Slot = "13")]
	public bool Contains(T ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5270220", Offset = "0x526F220", VA = "0x185270220", Slot = "14")]
	public void CopyTo(T[] MFIJBPNIELL, int EFMHKDAINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5270250", Offset = "0x526F250", VA = "0x185270250", Slot = "6")]
	public int IndexOf(T ADPMEPGEIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5270290", Offset = "0x526F290", VA = "0x185270290", Slot = "7")]
	public void Insert(int HLGKMAPOEBE, T ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5270670", Offset = "0x526F670", VA = "0x185270670", Slot = "8")]
	public void RemoveAt(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5270870", Offset = "0x526F870", VA = "0x185270870")]
	public AMABHBOHMCE()
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
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2CCB720", Offset = "0x2CCA720", VA = "0x182CCB720")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8132ED0", Offset = "0x8131ED0", VA = "0x188132ED0")]
		public SerializedGuid([In] Guid JFLBGDIIGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8132DA0", Offset = "0x8131DA0", VA = "0x188132DA0")]
		public static SerializedGuid MJHLNKIBIPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8132BC0", Offset = "0x8131BC0", VA = "0x188132BC0")]
		public static SerializedGuid BINAEFPDEFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8132C30", Offset = "0x8131C30", VA = "0x188132C30")]
		public bool BMKKEHNACIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8132EA0", Offset = "0x8131EA0", VA = "0x188132EA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8132E20", Offset = "0x8131E20", VA = "0x188132E20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8132CC0", Offset = "0x8131CC0", VA = "0x188132CC0", Slot = "7")]
		public bool Equals(SerializedGuid EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8132D00", Offset = "0x8131D00", VA = "0x188132D00", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8132D90", Offset = "0x8131D90", VA = "0x188132D90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8132C90", Offset = "0x8131C90", VA = "0x188132C90", Slot = "6")]
		public int CompareTo(SerializedGuid EDJHHGMLKFA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KKNKAKOIDDD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type FPHCBGKPOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string KAEMDCAAFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool OCPJELNKHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool LAIAKJFDCEJ;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x81309E0", Offset = "0x812F9E0", VA = "0x1881309E0")]
	public KKNKAKOIDDD(Type GHALGMEPMIC, string IGJPDHIKHHG, bool MFNHKJOBIFJ = false, bool FLBELOLMBIK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GBKCCGIPBFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int AMEKJEILKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> AOJPFCKAHKF(float JAPNNLNNKKI, [Optional] float? MBPNCMKNNPH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GJAPOIBGHII(float JAPNNLNNKKI, T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPJFAMEFLHG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class OGKIBFFGIHF<T> : GBKCCGIPBFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class GOLNNNOFLBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float DFPDPKDEFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T BDJLGAHJNPH;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GOLNNNOFLBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JHAFMJMMKJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public JHAFMJMMKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x52A8110", Offset = "0x52A7110", VA = "0x1852A8110")]
		internal bool CLPCAKJGMAF(GOLNNNOFLBF sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float HOALJAFCHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float MMEOFINNJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<GOLNNNOFLBF> KNEHCBOFJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private OBGJACJFCAK<GOLNNNOFLBF> NADMHOPCCPH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int AMEKJEILKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x58B0F10", Offset = "0x58AFF10", VA = "0x1858B0F10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x58B19D0", Offset = "0x58B09D0", VA = "0x1858B19D0")]
	public OGKIBFFGIHF(float KAOADGNJPMN, float PNJFINKNPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x58B1800", Offset = "0x58B0800", VA = "0x1858B1800", Slot = "6")]
	public bool GJAPOIBGHII(float JAPNNLNNKKI, T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x58B1270", Offset = "0x58B0270", VA = "0x1858B1270", Slot = "5")]
	public IEnumerable<T> AOJPFCKAHKF(float JAPNNLNNKKI, float? MBPNCMKNNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x58B1970", Offset = "0x58B0970", VA = "0x1858B1970", Slot = "7")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x58B1560", Offset = "0x58B0560", VA = "0x1858B1560")]
	private void DCKJLAKACAC(float JAPNNLNNKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class DGCPGINODAP<T> : GBKCCGIPBFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct PDOMGDPLMPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T BDJLGAHJNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float DFPDPKDEFKK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5447D60", Offset = "0x5446D60", VA = "0x185447D60")]
		public PDOMGDPLMPJ(T IOALKPFEKEK, float JAPNNLNNKKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NCDFKHDJFNN : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public DGCPGINODAP<T> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public NCDFKHDJFNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5777EE0", Offset = "0x5776EE0", VA = "0x185777EE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5778370", Offset = "0x5777370", VA = "0x185778370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x57781F0", Offset = "0x57771F0", VA = "0x1857781F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4FB80A0", Offset = "0x4FB70A0", VA = "0x184FB80A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float KAOADGNJPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float PNJFINKNPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<PDOMGDPLMPJ> KNEHCBOFJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int OBJODNIPNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int OICCBIDLLGD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int AMEKJEILKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FFA0", Offset = "0x6E8EFA0", VA = "0x186E8FFA0")]
	public DGCPGINODAP(float KAOADGNJPMN, float PNJFINKNPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FB60", Offset = "0x6E8EB60", VA = "0x186E8FB60", Slot = "6")]
	public bool GJAPOIBGHII(float JAPNNLNNKKI, T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FDA0", Offset = "0x6E8EDA0", VA = "0x186E8FDA0", Slot = "8")]
	public int JFHJAFBIKCK(float JAPNNLNNKKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F880", Offset = "0x6E8E880", VA = "0x186E8F880", Slot = "5")]
	[IteratorStateMachine(typeof(DGCPGINODAP<>.NCDFKHDJFNN))]
	public IEnumerable<T> AOJPFCKAHKF(float JAPNNLNNKKI, float? MBPNCMKNNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FDD0", Offset = "0x6E8EDD0", VA = "0x186E8FDD0", Slot = "7")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FED0", Offset = "0x6E8EED0", VA = "0x186E8FED0")]
	private void NFHHAIECPPM(float JAPNNLNNKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F710", Offset = "0x6E8E710", VA = "0x186E8F710")]
	private PDOMGDPLMPJ ACOODMMAPBD()
	{
		return default(PDOMGDPLMPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class CNPHBADCGMN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct EHDCCDKOOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long KDJBDCKLGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long CAEGKDPPPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int FHANFAANNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int CLPLKBLDBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool LMFKELGAKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string FFBBNMBIDDD;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x49016B0", Offset = "0x49006B0", VA = "0x1849016B0")]
		public EHDCCDKOOBK(long KDJBDCKLGHC, int FHANFAANNAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4901720", Offset = "0x4900720", VA = "0x184901720")]
		public EHDCCDKOOBK(long KDJBDCKLGHC, long CAEGKDPPPPM, int FHANFAANNAK, int CLPLKBLDBKE, bool LMFKELGAKPH, string FFBBNMBIDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4901660", Offset = "0x4900660", VA = "0x184901660")]
		public int PKBBMMOPGGJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4901540", Offset = "0x4900540", VA = "0x184901540")]
		public int DAFMAGHCHKC(int BNELPKPKOEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4901600", Offset = "0x4900600", VA = "0x184901600")]
		public double IDBAKLHINFK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4901560", Offset = "0x4900560", VA = "0x184901560")]
		public EHDCCDKOOBK EMLLDPFDNJJ(long CAEGKDPPPPM, int CLPLKBLDBKE)
		{
			return default(EHDCCDKOOBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class FNGDFCAOPOO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct LGEEINFHMHE<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public FNGDFCAOPOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<FNGDFCAOPOO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private FNGDFCAOPOO <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x54713D0", Offset = "0x54703D0", VA = "0x1854713D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4EEBBD0", Offset = "0x4EEABD0", VA = "0x184EEBBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey OKAFGBBEFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly CNPHBADCGMN<TKey> HDAJLMNMKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly ONIHMLNNEEF EFJNGOKNPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<FNGDFCAOPOO> KDCHKKINBEA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string MJNIJEOGPOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4DAE7B0", Offset = "0x4DAD7B0", VA = "0x184DAE7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<FNGDFCAOPOO> JAKCMLAGBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4DAE780", Offset = "0x4DAD780", VA = "0x184DAE780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public EHDCCDKOOBK PLJFDAADODK
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4DAE400", Offset = "0x4DAD400", VA = "0x184DAE400")]
			[CompilerGenerated]
			get
			{
				return default(EHDCCDKOOBK);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4DAE750", Offset = "0x4DAD750", VA = "0x184DAE750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4DAE7E0", Offset = "0x4DAD7E0", VA = "0x184DAE7E0")]
		internal FNGDFCAOPOO(CNPHBADCGMN<TKey> HDAJLMNMKDM, TKey DAKIIEIEKNI, ONIHMLNNEEF EFJNGOKNPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4DAE420", Offset = "0x4DAD420", VA = "0x184DAE420")]
		public FNGDFCAOPOO CDNEDOICBFE(TKey DAKIIEIEKNI, [Optional] ONIHMLNNEEF? LNDMMMJDGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3D720F0", Offset = "0x3D710F0", VA = "0x183D720F0")]
		[AsyncStateMachine(typeof(LGEEINFHMHE<>))]
		public Task<T> EMALDADLOHH<T>(TKey DAKIIEIEKNI, Func<FNGDFCAOPOO, Task<T>> MIHDDGGCGJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4DAE570", Offset = "0x4DAD570", VA = "0x184DAE570", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class OFAFBCOJFJL : IEnumerable<(TKey, List<TKey>, EHDCCDKOOBK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EHDCCDKOOBK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, EHDCCDKOOBK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CNPHBADCGMN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, EHDCCDKOOBK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, EHDCCDKOOBK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2CCFA70", Offset = "0x2CCEA70", VA = "0x182CCFA70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EHDCCDKOOBK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x58A2D00", Offset = "0x58A1D00", VA = "0x1858A2D00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2CCFB60", Offset = "0x2CCEB60", VA = "0x182CCFB60")]
		[DebuggerHidden]
		public OFAFBCOJFJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E13DA0", Offset = "0x4E12DA0", VA = "0x184E13DA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x58A2870", Offset = "0x58A1870", VA = "0x1858A2870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x58A2820", Offset = "0x58A1820", VA = "0x1858A2820")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x58A2CB0", Offset = "0x58A1CB0", VA = "0x1858A2CB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x58A2BF0", Offset = "0x58A1BF0", VA = "0x1858A2BF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EHDCCDKOOBK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x44B4610", Offset = "0x44B3610", VA = "0x1844B4610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MOGIOBHONJL : IEnumerable<(TKey, List<TKey>, EHDCCDKOOBK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EHDCCDKOOBK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, EHDCCDKOOBK timerEntry) <>2__current;

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
		private FNGDFCAOPOO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FNGDFCAOPOO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CNPHBADCGMN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<FNGDFCAOPOO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, EHDCCDKOOBK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, EHDCCDKOOBK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2CCFA70", Offset = "0x2CCEA70", VA = "0x182CCFA70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EHDCCDKOOBK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x56FDB50", Offset = "0x56FCB50", VA = "0x1856FDB50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2CCFB60", Offset = "0x2CCEB60", VA = "0x182CCFB60")]
		[DebuggerHidden]
		public MOGIOBHONJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x56FDBB0", Offset = "0x56FCBB0", VA = "0x1856FDBB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x56FD290", Offset = "0x56FC290", VA = "0x1856FD290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x56FD1D0", Offset = "0x56FC1D0", VA = "0x1856FD1D0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x56FD230", Offset = "0x56FC230", VA = "0x1856FD230")]
		private void FNICMDFFEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x56FDB00", Offset = "0x56FCB00", VA = "0x1856FDB00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x56FD9F0", Offset = "0x56FC9F0", VA = "0x1856FD9F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EHDCCDKOOBK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x56FDAD0", Offset = "0x56FCAD0", VA = "0x1856FDAD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, EHDCCDKOOBK, ONIHMLNNEEF> AMGMDILDDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, EHDCCDKOOBK, ONIHMLNNEEF> OCOGNEKOKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<CNPHBADCGMN<TKey>, ONIHMLNNEEF> HBDAMGNGGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FNGDFCAOPOO EGPLLGDNKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool BFHCDNIGCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int PFLDDLIMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch DKLCMMEFFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int LJNCFFACPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string PDAKHADPEDC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FNGDFCAOPOO KAEDNMHOAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string MJNIJEOGPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x69907B0", Offset = "0x698F7B0", VA = "0x1869907B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6990810", Offset = "0x698F810", VA = "0x186990810")]
	public CNPHBADCGMN(TKey PBINALLKPIM, ONIHMLNNEEF EFJNGOKNPIL, [Optional] int? FHANFAANNAK, [Optional][CanBeNull] Stopwatch DKLCMMEFFPP, [Optional] Action<TKey, EHDCCDKOOBK, ONIHMLNNEEF> AMGMDILDDJL, [Optional] Action<TKey, EHDCCDKOOBK, ONIHMLNNEEF> OCOGNEKOKCG, [Optional] Action<CNPHBADCGMN<TKey>, ONIHMLNNEEF> HBDAMGNGGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6990540", Offset = "0x698F540", VA = "0x186990540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x69905D0", Offset = "0x698F5D0", VA = "0x1869905D0")]
	[IteratorStateMachine(typeof(CNPHBADCGMN<>.OFAFBCOJFJL))]
	public IEnumerable<(TKey, List<TKey>, EHDCCDKOOBK)> IPGJAFNBJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6990660", Offset = "0x698F660", VA = "0x186990660")]
	[IteratorStateMachine(typeof(CNPHBADCGMN<>.MOGIOBHONJL))]
	private IEnumerable<(TKey, List<TKey>, EHDCCDKOOBK)> IPGJAFNBJKG(List<TKey> AIPDNDCFPID, FNGDFCAOPOO AMNPMOLJJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6990730", Offset = "0x698F730", VA = "0x186990730")]
	private (long, int) KACHPODCMBJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class KFDBEHMOKAH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KNIDNHNGIFE(CNPHBADCGMN<TKey> HDAJLMNMKDM);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected KFDBEHMOKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class EFHNLKOCCIA<TKey> : KFDBEHMOKAH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string DBDHDGINHCK(TKey DAKIIEIEKNI);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x48F8DE0", Offset = "0x48F7DE0", VA = "0x1848F8DE0")]
	private static string GMLEJLCKEPO(TKey DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x48F8F60", Offset = "0x48F7F60", VA = "0x1848F8F60", Slot = "4")]
	public override string KNIDNHNGIFE(CNPHBADCGMN<TKey> HDAJLMNMKDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x48F8E20", Offset = "0x48F7E20", VA = "0x1848F8E20")]
	public string KNIDNHNGIFE(CNPHBADCGMN<TKey> HDAJLMNMKDM, [NotNull] DBDHDGINHCK CIJEIIGOLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string CDJIDOKNAIK(CNPHBADCGMN<TKey> HDAJLMNMKDM, [NotNull] DBDHDGINHCK CIJEIIGOLEN);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x48F9010", Offset = "0x48F8010", VA = "0x1848F9010")]
	protected EFHNLKOCCIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MDAILLOBMAI<TKey> : KFDBEHMOKAH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string MHMJOJMKOGO(TKey DAKIIEIEKNI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string LCCEOOIFGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double IBOKOPMCFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool LGACPOCAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int ELGLMIHCKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> GGAOJNBDDPK;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5699990", Offset = "0x5698990", VA = "0x185699990")]
	private static string GMLEJLCKEPO(TKey DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x569A240", Offset = "0x5699240", VA = "0x18569A240")]
	public MDAILLOBMAI(string LCCEOOIFGKH = "F2", double IBOKOPMCFND = double.MaxValue, bool LGACPOCAGKL = false, int ELGLMIHCKOP = int.MaxValue, [Optional] ISet<string> GGAOJNBDDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5699F80", Offset = "0x5698F80", VA = "0x185699F80", Slot = "4")]
	public override Dictionary<string, string> KNIDNHNGIFE(CNPHBADCGMN<TKey> HDAJLMNMKDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x56997C0", Offset = "0x56987C0", VA = "0x1856997C0")]
	private bool BABLHHAPLBP(string NKEEKMDOHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56999D0", Offset = "0x56989D0", VA = "0x1856999D0")]
	public Dictionary<string, string> KNIDNHNGIFE(CNPHBADCGMN<TKey> HDAJLMNMKDM, MHMJOJMKOGO CIJEIIGOLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x569A030", Offset = "0x5699030", VA = "0x18569A030")]
	private string PGEJAKDGJAD(StringBuilder PGLCMDFAIPA, List<TKey> OKEIDLAKOAA, MHMJOJMKOGO CIJEIIGOLEN, bool AABFFBAJBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5699830", Offset = "0x5698830", VA = "0x185699830")]
	private static void FMDPHLFCGHJ(StringBuilder FPDEOBHLNAG, string NLJHAHNGHCG, bool BMPKPKEMIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KAMEKKACNEH<TKey> : EFHNLKOCCIA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct PHKFMOHACKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DBDHDGINHCK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static KAMEKKACNEH<TKey> KONBGMLOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] NLDOMPEDDIC;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5396B70", Offset = "0x5395B70", VA = "0x185396B70")]
	private KAMEKKACNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5395B30", Offset = "0x5394B30", VA = "0x185395B30", Slot = "5")]
	protected override string CDJIDOKNAIK(CNPHBADCGMN<TKey> HDAJLMNMKDM, DBDHDGINHCK CIJEIIGOLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5396950", Offset = "0x5395950", VA = "0x185396950")]
	[CompilerGenerated]
	internal static string OGJBODNCJBB(string BIGEINDFMAE, TKey DAKIIEIEKNI, PHKFMOHACKA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class LDCFFPCEFAB : CNPHBADCGMN<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EGIKKNHAJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<LDCFFPCEFAB, ONIHMLNNEEF> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EGIKKNHAJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8130300", Offset = "0x812F300", VA = "0x188130300")]
		internal void BCGBGNKJMBM(CNPHBADCGMN<string> timer, ONIHMLNNEEF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8130B10", Offset = "0x812FB10", VA = "0x188130B10")]
	public LDCFFPCEFAB(ONIHMLNNEEF EFJNGOKNPIL, [Optional] string FIMHLBNGDLF, [Optional] int? FHANFAANNAK, [Optional] Stopwatch DKLCMMEFFPP, [Optional] Action<string, EHDCCDKOOBK, ONIHMLNNEEF> AMGMDILDDJL, [Optional] Action<string, EHDCCDKOOBK, ONIHMLNNEEF> OCOGNEKOKCG, [Optional] Action<LDCFFPCEFAB, ONIHMLNNEEF> HBDAMGNGGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8130A50", Offset = "0x812FA50", VA = "0x188130A50")]
	private static Action<CNPHBADCGMN<string>, ONIHMLNNEEF> PECBJBGLKMB(Action<LDCFFPCEFAB, ONIHMLNNEEF> HCEFPMMOBCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class JDOIFDFECKO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class OIEGALFMDHL : JDOIFDFECKO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static JDOIFDFECKO KONBGMLOLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8130D40", Offset = "0x812FD40", VA = "0x188130D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float AFCJEFGMPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1333160", Offset = "0x1332160", VA = "0x181333160", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8130E40", Offset = "0x812FE40", VA = "0x188130E40")]
		public OIEGALFMDHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static JDOIFDFECKO NGKIOJOKPJI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static JDOIFDFECKO HPFHFAKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8130870", Offset = "0x812F870", VA = "0x188130870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float AFCJEFGMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected JDOIFDFECKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface INKKKBPBHOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PHNCGCCJBCF<T> : INKKKBPBHOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> BAIEBDODCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	KPIPLFECKNC<T> BLHKOALKMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BNFJCLJFCOD
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x39DCC80", Offset = "0x39DBC80", VA = "0x1839DCC80")]
	public static PHNCGCCJBCF<TResource> IMOJHCKAGNK<TResource, TId>(this DGHFOCDINCJ<TId, TResource> HMLPKMOGHLI, TId PBJHGGBBAAF, [Optional] Func<TId, CancellationToken, Task<TResource>>? CCAPJBLIJPI) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MCBGILHDMID
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class CNAKBEACKBB<T> : GMNJNIMLIFG<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> BAIEBDODCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override KPIPLFECKNC<T?> BLHKOALKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x698F760", Offset = "0x698E760", VA = "0x18698F760")]
		public CNAKBEACKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
		protected override void BEHPICPFFKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class POOGANCJLMA<T> : GMNJNIMLIFG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T PKPJFEEBMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? KOJOMHIIBFB;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> BAIEBDODCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override KPIPLFECKNC<T> BLHKOALKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5A86F10", Offset = "0x5A85F10", VA = "0x185A86F10")]
		public POOGANCJLMA(T LFGKBEOOJHO, Action<T>? JAADGDFNDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5A86E90", Offset = "0x5A85E90", VA = "0x185A86E90", Slot = "10")]
		protected override void BEHPICPFFKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class OIMMNDOIEDP<T> : GMNJNIMLIFG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> BAIEBDODCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override KPIPLFECKNC<T> BLHKOALKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5935020", Offset = "0x5934020", VA = "0x185935020")]
		public OIMMNDOIEDP(Exception KKDGPEIEFMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
		protected override void BEHPICPFFKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class OMGLJGLLJJH<T> : GMNJNIMLIFG<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct GNJEGHLBJPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<PHNCGCCJBCF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PHNCGCCJBCF<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4EEA710", Offset = "0x4EE9710", VA = "0x184EEA710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4EEB090", Offset = "0x4EEA090", VA = "0x184EEB090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct BLDHEKJOFPP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<PHNCGCCJBCF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<PHNCGCCJBCF<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x65175A0", Offset = "0x65165A0", VA = "0x1865175A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x65179E0", Offset = "0x65169E0", VA = "0x1865179E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<PHNCGCCJBCF<T>> KMEPCBDNAFJ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> BAIEBDODCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KPIPLFECKNC<T> BLHKOALKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x59562E0", Offset = "0x59552E0", VA = "0x1859562E0")]
		public OMGLJGLLJJH(Task<PHNCGCCJBCF<T>> CAIMNCAIJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5955D80", Offset = "0x5954D80", VA = "0x185955D80", Slot = "10")]
		protected override void BEHPICPFFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5956040", Offset = "0x5955040", VA = "0x185956040")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(OMGLJGLLJJH<>.GNJEGHLBJPO))]
		internal static Task<T> OEGOEMNLNBC(Task<PHNCGCCJBCF<T>> CAIMNCAIJDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5955E80", Offset = "0x5954E80", VA = "0x185955E80")]
		[AsyncStateMachine(typeof(OMGLJGLLJJH<>.BLDHEKJOFPP))]
		[CompilerGenerated]
		internal static Task FBBAMOOKPPK(Task<PHNCGCCJBCF<T>> CAIMNCAIJDI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class OLNNBIPHPED<TIn, TOut> : GMNJNIMLIFG<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct EHGLKAJJOFA : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4901E30", Offset = "0x4900E30", VA = "0x184901E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4902470", Offset = "0x4901470", VA = "0x184902470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly PHNCGCCJBCF<TIn> FJOPHLKOBLF;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> BAIEBDODCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override KPIPLFECKNC<TOut> BLHKOALKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x594B1F0", Offset = "0x594A1F0", VA = "0x18594B1F0")]
		public OLNNBIPHPED(PHNCGCCJBCF<TIn> BHIKKLPDMIB, Func<TIn, TOut> EKNMGFDFMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x594AEC0", Offset = "0x5949EC0", VA = "0x18594AEC0", Slot = "10")]
		protected override void BEHPICPFFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x594AF10", Offset = "0x5949F10", VA = "0x18594AF10")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(OLNNBIPHPED<, >.EHGLKAJJOFA))]
		internal static Task<TOut> IFHGBGLGCIL(Task<TIn> NCEPNAKCHNG, Func<TIn, TOut> EKNMGFDFMEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B9C0", Offset = "0x3D7A9C0", VA = "0x183D7B9C0")]
	public static PHNCGCCJBCF<T> JBLEAIPIMOC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BA20", Offset = "0x3D7AA20", VA = "0x183D7BA20")]
	public static PHNCGCCJBCF<T> PPBAFICIDCP<T>(T BGOCMPMGKKI, [Optional] Action<T>? JAADGDFNDMC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x39D4600", Offset = "0x39D3600", VA = "0x1839D4600")]
	public static PHNCGCCJBCF<T> PBBNAGPDKHP<T>(Exception KKDGPEIEFMH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x39D4600", Offset = "0x39D3600", VA = "0x1839D4600")]
	public static PHNCGCCJBCF<T> EFAILADCCHF<T>(Task<PHNCGCCJBCF<T>> CAIMNCAIJDI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x39DD070", Offset = "0x39DC070", VA = "0x1839DD070")]
	public static PHNCGCCJBCF<TOut> DBHNDLPLFNO<TOut, TIn>(PHNCGCCJBCF<TIn> EBEJPHPLJAD, Func<TIn, TOut> EKNMGFDFMEN) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class GMNJNIMLIFG<T> : PHNCGCCJBCF<T>, INKKKBPBHOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string ABFKFLOAAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CBOONJONPNE GMMGFHCIEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool BFHCDNIGCPC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB3C180", Offset = "0xB3B180", VA = "0x180B3C180", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> BAIEBDODCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract KPIPLFECKNC<T> BLHKOALKMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5260", Offset = "0x4ED4260", VA = "0x184ED5260")]
	public GMNJNIMLIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5120", Offset = "0x4ED4120", VA = "0x184ED5120", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BEHPICPFFKM();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class LLDFFJLICBL<TTask, T> : GMNJNIMLIFG<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class PHHNDAHFIOF
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
			public PHHNDAHFIOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x445D060", Offset = "0x445C060", VA = "0x18445D060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x445D320", Offset = "0x445C320", VA = "0x18445D320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LLDFFJLICBL<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PHHNDAHFIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5A6ADA0", Offset = "0x5A69DA0", VA = "0x185A6ADA0")]
		[AsyncStateMachine(typeof(LLDFFJLICBL<, >.PHHNDAHFIOF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> BMOLMNIGEOP(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> CAIMNCAIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource KGNGGHKAGHI;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> BAIEBDODCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override KPIPLFECKNC<T> BLHKOALKMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x54B7170", Offset = "0x54B6170", VA = "0x1854B7170")]
	protected LLDFFJLICBL(TTask CAIMNCAIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x54B7120", Offset = "0x54B6120", VA = "0x1854B7120", Slot = "10")]
	protected override void BEHPICPFFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T KNHIMANFDCI(TTask NEDGHPKHHHC);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void AFGNFJCCJFA();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MGEDIJEBIOH<T> : GMNJNIMLIFG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly DMEMIKDFAED<Task<T>> GMGKNBNJCBP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> BAIEBDODCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4D77670", Offset = "0x4D76670", VA = "0x184D77670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override KPIPLFECKNC<T> BLHKOALKMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x56B5550", Offset = "0x56B4550", VA = "0x1856B5550")]
	public MGEDIJEBIOH(DMEMIKDFAED<Task<T>> IPPCBDNDGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x56B5530", Offset = "0x56B4530", VA = "0x1856B5530", Slot = "10")]
	protected override void BEHPICPFFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OMEMLBIMJOC
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName OKBBIIJEPJA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> MCHCCMEJILL;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x81315D0", Offset = "0x81305D0", VA = "0x1881315D0")]
	public static int PICFNJOCNOA(this AJIJOGMEBDH OBGLDPNMHGN, IncrementalHash EGEGACCNNEK, byte[] POBCPMCPCHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8130E90", Offset = "0x812FE90", VA = "0x188130E90")]
	public static bool GICGMKELBFM([CanBeNull] this AJIJOGMEBDH OBGLDPNMHGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8131230", Offset = "0x8130230", VA = "0x188131230")]
	public static bool GICGMKELBFM([CanBeNull] this AJIJOGMEBDH OBGLDPNMHGN, [Out] string MGECNFLHDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8130EF0", Offset = "0x812FEF0", VA = "0x188130EF0")]
	public static bool GICGMKELBFM([CanBeNull] this AJIJOGMEBDH OBGLDPNMHGN, IncrementalHash EGEGACCNNEK, byte[] POBCPMCPCHO, [Out] string MGECNFLHDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8131540", Offset = "0x8130540", VA = "0x188131540")]
	private static bool PFPNJPFPDPD(byte[] LKEHLCMHMKP, Span<byte> LLHDMPEMAPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class HLHAHIBMFIB
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8130720", Offset = "0x812F720", VA = "0x188130720")]
	public static int DLADADJFMAC(HashAlgorithmName PDNCIEFKLGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3C83200", Offset = "0x3C82200", VA = "0x183C83200")]
	public static int PICFNJOCNOA<T>(this T KEFJJIDICII, byte[] GJMFFOALHHK, IncrementalHash EGEGACCNNEK, byte[] OPPNJALNKEJ) where T : EILONDPOBCI
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EILONDPOBCI
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash EGEGACCNNEK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface AJIJOGMEBDH : EILONDPOBCI
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] BCHPOCOMJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] OCIOEONGJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AGMAFBMDCDE
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool DBNPGEJCLNI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> HELHHCCJLLD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> ENBAIMCAAJD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding LDKJJAKJCCE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> PDAFPGNBCEH;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x319D7A0", Offset = "0x319C7A0", VA = "0x18319D7A0")]
	public static void PJGCOAMJGAO<T>(this IncrementalHash LJDELKLMNED, [CanBeNull] T LDEFIHHDIJL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x319C590", Offset = "0x319B590", VA = "0x18319C590")]
	public static void DOIFBKOBNFO<T>(this IncrementalHash LJDELKLMNED, [CanBeNull] T KEFJJIDICII) where T : EILONDPOBCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x319C620", Offset = "0x319B620", VA = "0x18319C620")]
	public static void FDJOMIOMNNE<T>(this IncrementalHash LJDELKLMNED, [CanBeNull] IList<T> MGKLCDLINLF) where T : EILONDPOBCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x812EC90", Offset = "0x812DC90", VA = "0x18812EC90")]
	private static bool DLFKMLHLLDN([CanBeNull] EILONDPOBCI KEFJJIDICII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x812F3A0", Offset = "0x812E3A0", VA = "0x18812F3A0")]
	public static void KKIPAFAEBDN(this IncrementalHash EGEGACCNNEK, string? FLBGBCKEEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x812F1D0", Offset = "0x812E1D0", VA = "0x18812F1D0")]
	public static void IHPHGCLEKDK(this IncrementalHash EGEGACCNNEK, long MFFEEBHIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x812F940", Offset = "0x812E940", VA = "0x18812F940")]
	public static void NGNLBEDOEPH(this IncrementalHash EGEGACCNNEK, int IFPDNIOFMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x812ED20", Offset = "0x812DD20", VA = "0x18812ED20")]
	public static void FBGHHOMFGIN(this IncrementalHash EGEGACCNNEK, short ACBOABMEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x812EEF0", Offset = "0x812DEF0", VA = "0x18812EEF0")]
	public static void FFPIEMDGLFG(this IncrementalHash EGEGACCNNEK, byte OGPHDDDLFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x812F000", Offset = "0x812E000", VA = "0x18812F000")]
	public static void HGPNNGPGLEK(this IncrementalHash EGEGACCNNEK, bool HPDDGMJIGJI, bool BDFCJKCGHHG = false, bool MANOLJACAMH = false, bool HFIGKKIKHPJ = false, bool ODFEPIOKANH = false, bool OANJKMMBIEM = false, bool NDMNDMCAFLN = false, bool JHILCOPEMCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x319CB40", Offset = "0x319BB40", VA = "0x18319CB40")]
	public static void OCBJGBGOHKB<T>(this IncrementalHash EGEGACCNNEK, T EINBKGFECKN) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x812FB10", Offset = "0x812EB10", VA = "0x18812FB10")]
	public static void NMCODOOLBNC(this IncrementalHash EGEGACCNNEK, float ILOODJLIBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x812EC30", Offset = "0x812DC30", VA = "0x18812EC30")]
	public static void BBFBFLAFINA(this IncrementalHash EGEGACCNNEK, ulong KMADGFLMMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x812F170", Offset = "0x812E170", VA = "0x18812F170")]
	public static void HMHECDPNLIO(this IncrementalHash EGEGACCNNEK, uint EOHDMPEANJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x812F7B0", Offset = "0x812E7B0", VA = "0x18812F7B0")]
	public static void LKALLOJGBPP(this IncrementalHash EGEGACCNNEK, ushort NPOOBIFHJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x812F810", Offset = "0x812E810", VA = "0x18812F810")]
	public static void LMNAOPCEKIH(this IncrementalHash EGEGACCNNEK, Vector3 ALMAGIBPKFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OEPCOLMMKHJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8130CE0", Offset = "0x812FCE0", VA = "0x188130CE0")]
	public OEPCOLMMKHJ(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class ONMAFDCHBDD
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void EEILJGAJEII(ushort CIPDBHHPMHC, ushort KNCFIAFPMCI, ushort OBDLPAIMAEL, ushort KPMCBEIGGNO);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void APDLCEBMDMH(ushort HIIKLMLMNBF, ushort GNOFNBGOKEC);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void ACFJNHHIIND();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort DLBLJGPCEFL = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected ONMAFDCHBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class EEHEGFOHPKO<T> : ONMAFDCHBDD where T : EEHEGFOHPKO<T>.KJJIAMNDBFB
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface KJJIAMNDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		APDLCEBMDMH NFEGLCMNOIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		APDLCEBMDMH PJDOICJCFNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ACFJNHHIIND FDIMCIOLIJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> MANPFGFPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private ACFJNHHIIND MMMOOJIPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private ACFJNHHIIND KGIGFECDKIN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DCFFKHHCGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort BFKKINNHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x11FD280", Offset = "0x11FC280", VA = "0x1811FD280")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x11FCDE0", Offset = "0x11FBDE0", VA = "0x1811FCDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort FKAMDBMIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x48F2330", Offset = "0x48F1330", VA = "0x1848F2330")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x48F16F0", Offset = "0x48F06F0", VA = "0x1848F16F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort CHILAHMJGFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE10", Offset = "0xF0AE10", VA = "0x180F0BE10")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xF0BED0", Offset = "0xF0AED0", VA = "0x180F0BED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort NGDFGIAPHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x48F1680", Offset = "0x48F0680", VA = "0x1848F1680")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x48F16E0", Offset = "0x48F06E0", VA = "0x1848F16E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool AJPJKIDNCII
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x11FCCC0", Offset = "0x11FBCC0", VA = "0x1811FCCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool NBLPIPEALIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xFFD8C0", Offset = "0xFFC8C0", VA = "0x180FFD8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EEILJGAJEII AHHEIBOCOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x48F1550", Offset = "0x48F0550", VA = "0x1848F1550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x48F2140", Offset = "0x48F1140", VA = "0x1848F2140")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x48F15F0", Offset = "0x48F05F0", VA = "0x1848F15F0")]
	private T AKMOPOPGNOA(ushort IMGKAOCFEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x48F22A0", Offset = "0x48F12A0", VA = "0x1848F22A0")]
	private T NNNKDBBJADG(ushort IMGKAOCFEIB, ushort HJNFBMKEHLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x48F1690", Offset = "0x48F0690", VA = "0x1848F1690")]
	protected T CKCNIDCNPJD(uint HMNBLJLFIEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x48F2340", Offset = "0x48F1340", VA = "0x1848F2340")]
	protected EEHEGFOHPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x48F2010", Offset = "0x48F1010", VA = "0x1848F2010")]
	public void FOEANGIHDJN(ushort BLAAOAHAOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x48F20F0", Offset = "0x48F10F0", VA = "0x1848F20F0")]
	public void FOEANGIHDJN(ushort BLAAOAHAOAD, ushort NDJBJIBCKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x48F2030", Offset = "0x48F1030", VA = "0x1848F2030", Slot = "4")]
	protected virtual void FOEANGIHDJN(uint FADNIPEEMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x48F1700", Offset = "0x48F0700", VA = "0x1848F1700")]
	protected void ELLBANEHFNK(uint FADNIPEEMPO, uint DFADJOIFJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x48F2220", Offset = "0x48F1220", VA = "0x1848F2220")]
	protected void KBKHJIDFAPC(ushort IMGKAOCFEIB, ushort HJNFBMKEHLD, T GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x48F21E0", Offset = "0x48F11E0", VA = "0x1848F21E0")]
	private void JEIBGDEBNOG(uint HMNBLJLFIEJ, T GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x48F1DE0", Offset = "0x48F0DE0", VA = "0x1848F1DE0")]
	protected void ENELHDKOILC(float PFFBKHOBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x48F16D0", Offset = "0x48F06D0", VA = "0x1848F16D0")]
	protected uint CKFNMHDAIFJ(ushort IMGKAOCFEIB, ushort HJNFBMKEHLD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x48F2210", Offset = "0x48F1210", VA = "0x1848F2210")]
	protected ushort JLEDLIJMNIN(uint MNHEPCBGANA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x48F2290", Offset = "0x48F1290", VA = "0x1848F2290")]
	protected ushort KFFOIBJAEIN(uint MNHEPCBGANA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class GFEGAKBOMDA : EEHEGFOHPKO<GFEGAKBOMDA.DFDLJEIKODP>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class DFDLJEIKODP : KJJIAMNDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public APDLCEBMDMH NFEGLCMNOIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public APDLCEBMDMH PJDOICJCFNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ACFJNHHIIND FDIMCIOLIJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DFDLJEIKODP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8130410", Offset = "0x812F410", VA = "0x188130410")]
	public void OBLJGGFFACP(ushort POIAAALPBAG, APDLCEBMDMH BJPKLHIKBKC, APDLCEBMDMH ADAKGMDIBNO, ACFJNHHIIND FNHOEMHKPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x81304F0", Offset = "0x812F4F0", VA = "0x1881304F0")]
	public void OBLJGGFFACP(ushort IMGKAOCFEIB, ushort HJNFBMKEHLD, APDLCEBMDMH BJPKLHIKBKC, APDLCEBMDMH ADAKGMDIBNO, ACFJNHHIIND FNHOEMHKPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x81305D0", Offset = "0x812F5D0", VA = "0x1881305D0")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8130620", Offset = "0x812F620", VA = "0x188130620")]
	protected GFEGAKBOMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GGLELKKAJFL : GFEGAKBOMDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool ELGBPIJDJIK;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD243D0", Offset = "0xD233D0", VA = "0x180D243D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD40", Offset = "0xDCED40", VA = "0x180DCFD40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x81306C0", Offset = "0x812F6C0", VA = "0x1881306C0")]
	public void OCOPJMCPGIB(ushort GBENIEOIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8130660", Offset = "0x812F660", VA = "0x188130660")]
	public void OCOPJMCPGIB(ushort GBENIEOIIAI, ushort JBKLGPIIOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8130620", Offset = "0x812F620", VA = "0x188130620")]
	public GGLELKKAJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class DMHIANFIEPI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class ENAENBIGOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode OLHDOIOOPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode EBJBKAEFOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FGFEACFBFJD FICFFHNKAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<FGFEACFBFJD> KFOAPDLHICK;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ENAENBIGOME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct FGFEACFBFJD : IComparable<FGFEACFBFJD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int PAAKFDIMFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant NAIOAGOBPDN;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x188EFE0", Offset = "0x188DFE0", VA = "0x18188EFE0")]
		public FGFEACFBFJD(int PAAKFDIMFIA, TClaimant NAIOAGOBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C100", Offset = "0x4D8B100", VA = "0x184D8C100")]
		public bool HIFJPICCFCN([In] FGFEACFBFJD EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C0E0", Offset = "0x4D8B0E0", VA = "0x184D8C0E0")]
		public bool CLINCBAHFIO([In] FGFEACFBFJD EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C0F0", Offset = "0x4D8B0F0", VA = "0x184D8C0F0", Slot = "4")]
		public int CompareTo(FGFEACFBFJD EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C160", Offset = "0x4D8B160", VA = "0x184D8C160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum MLLAGPKOCIM
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class LFPEADHAEDF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public DMHIANFIEPI<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public LFPEADHAEDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5471130", Offset = "0x5470130", VA = "0x185471130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x54712F0", Offset = "0x54702F0", VA = "0x1854712F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5471210", Offset = "0x5470210", VA = "0x185471210", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4E15550", Offset = "0x4E14550", VA = "0x184E15550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly OBGJACJFCAK<ENAENBIGOME> POKPFFDMBNA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly OBGJACJFCAK<List<FGFEACFBFJD>> HKKCEHKHGIC;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int CCHLINPJMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> GJNJMBIPGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, ENAENBIGOME> NEIFMOELPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private MLLAGPKOCIM PBBNDGKGPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GHBGGJNGHEC(TNode ABOLKPCCJOL);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CAKEDEDJNDE(TNode ABOLKPCCJOL, TClaimant KNAPLMIOFJF, TClaimant FJFKJKFEHDA);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4498850", Offset = "0x4497850", VA = "0x184498850")]
	public DMHIANFIEPI(MLLAGPKOCIM PBBNDGKGPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x44971E0", Offset = "0x44961E0", VA = "0x1844971E0")]
	public void DNMNLNDPEPP(TNode ABOLKPCCJOL, TNode BKAKGIFOLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x44977B0", Offset = "0x44967B0", VA = "0x1844977B0")]
	public void HLHCCGBGDNA(TClaimant NAIOAGOBPDN, TNode KECOKCCNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4497270", Offset = "0x4496270", VA = "0x184497270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4498600", Offset = "0x4497600", VA = "0x184498600")]
	private void PPMELHDAGHF(TClaimant NAIOAGOBPDN, TNode GMNKHLLHILL, TNode KECOKCCNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4497740", Offset = "0x4496740", VA = "0x184497740")]
	private int HIPKCEJFGGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4497420", Offset = "0x4496420", VA = "0x184497420")]
	private void GAPOHOFHBNA(TClaimant NAIOAGOBPDN, TNode DMMMBAMJNGO, TNode JBAIOIPGKBB, int KPHFOOOPLLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4497E60", Offset = "0x4496E60", VA = "0x184497E60")]
	private void KCKDPGGLKLB(FGFEACFBFJD FOHKEIKNONO, ENAENBIGOME BMNJGIBEPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4498230", Offset = "0x4497230", VA = "0x184498230")]
	private void MOIHEINGLBD(TClaimant NAIOAGOBPDN, TNode DMMMBAMJNGO, TNode JBAIOIPGKBB, int KPHFOOOPLLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x44984F0", Offset = "0x44974F0", VA = "0x1844984F0")]
	private void ONAIOOAEEBI(FGFEACFBFJD FOHKEIKNONO, TNode ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x44978D0", Offset = "0x44968D0", VA = "0x1844978D0")]
	private void HNKPAJKGDOC(FGFEACFBFJD FOHKEIKNONO, ENAENBIGOME BMNJGIBEPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4497FB0", Offset = "0x4496FB0", VA = "0x184497FB0")]
	private void LMLMDFAPJDL(ENAENBIGOME BMNJGIBEPLM, bool MMFEIKHKNON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4497B10", Offset = "0x4496B10", VA = "0x184497B10")]
	private void JJAFPKHKEBH(ENAENBIGOME BMNJGIBEPLM, TNode BKAKGIFOLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4497EE0", Offset = "0x4496EE0", VA = "0x184497EE0")]
	[IteratorStateMachine(typeof(DMHIANFIEPI<, >.LFPEADHAEDF))]
	private IEnumerable<TNode> LBGPHHLFAAO(TNode DMMMBAMJNGO, TNode JBAIOIPGKBB, bool NDFAJOJCINH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4497100", Offset = "0x4496100", VA = "0x184497100")]
	private ENAENBIGOME BMDMKCFADPK(TNode ABOLKPCCJOL, TNode EBJBKAEFOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x44980D0", Offset = "0x44970D0", VA = "0x1844980D0")]
	private ENAENBIGOME LPFHOIFHMGB(TNode ABOLKPCCJOL, TNode EBJBKAEFOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x44979B0", Offset = "0x44969B0", VA = "0x1844979B0")]
	private void IMNIHABJJHD(ENAENBIGOME BMNJGIBEPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class MMBBJBBHGFF<T> : IEnumerable<MMBBJBBHGFF<T>.GGFKNBLDAAF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct GGFKNBLDAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T IOALKPFEKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int HLGKMAPOEBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class HIADCMFHHEN : IEnumerator<GGFKNBLDAAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private MMBBJBBHGFF<T> JPAPECBEEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int HLGKMAPOEBE;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x492E7A0", Offset = "0x492D7A0", VA = "0x18492E7A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public GGFKNBLDAAF AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4F45F40", Offset = "0x4F44F40", VA = "0x184F45F40", Slot = "4")]
			get
			{
				return default(GGFKNBLDAAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4F45E50", Offset = "0x4F44E50", VA = "0x184F45E50")]
		public HIADCMFHHEN(MMBBJBBHGFF<T> JPAPECBEEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4F45D50", Offset = "0x4F44D50", VA = "0x184F45D50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4996130", Offset = "0x4995130", VA = "0x184996130", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x12C4280", Offset = "0x12C3280", VA = "0x1812C4280", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct MCONEKELCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool JHBJAPMJEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T IOALKPFEKEK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int DAOLKEOOJFJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> DMIKHICAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private MCONEKELCAH[] LGEDFOODIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int GMPGDEJCKCG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int KIIAHFAIAID
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4474990", Offset = "0x4473990", VA = "0x184474990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x56E80E0", Offset = "0x56E70E0", VA = "0x1856E80E0")]
	public MMBBJBBHGFF(int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x56E81B0", Offset = "0x56E71B0", VA = "0x1856E81B0")]
	public MMBBJBBHGFF(GGFKNBLDAAF[] IMBIMJMCMJM, bool HPAMOKPODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x56E7670", Offset = "0x56E6670", VA = "0x1856E7670")]
	public int IJNPCOCIAMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x56E76F0", Offset = "0x56E66F0", VA = "0x1856E76F0")]
	private int JDIJJEMLGKL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x56E75C0", Offset = "0x56E65C0", VA = "0x1856E75C0", Slot = "6")]
	protected virtual uint FJHDCEKFIJE(uint EGEGACCNNEK, T IOALKPFEKEK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x56E75E0", Offset = "0x56E65E0", VA = "0x1856E75E0")]
	public bool FLIAHEINFNB(T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x56E7480", Offset = "0x56E6480", VA = "0x1856E7480")]
	public int CAEJPFLLFOP(T IOALKPFEKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x56E7FF0", Offset = "0x56E6FF0", VA = "0x1856E7FF0")]
	public T PBNFLAJHCHK(int HLGKMAPOEBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x56E7D50", Offset = "0x56E6D50", VA = "0x1856E7D50")]
	public bool OGAMCDIANIG(T IOALKPFEKEK, bool ANIMNJDEAOA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x56E7DA0", Offset = "0x56E6DA0", VA = "0x1856E7DA0")]
	public bool OGAMCDIANIG(T IOALKPFEKEK, int HLGKMAPOEBE, bool ANIMNJDEAOA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x56E7540", Offset = "0x56E6540", VA = "0x1856E7540")]
	private int CHDAAMOODEF(int OBJODNIPNPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x56E8060", Offset = "0x56E7060", VA = "0x1856E8060", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x56E8060", Offset = "0x56E7060", VA = "0x1856E8060", Slot = "4")]
	private IEnumerator<GGFKNBLDAAF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class OBGJACJFCAK<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> LNCIHDIOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> JOJBIOAECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int OBGIPLPBHFA;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5897F80", Offset = "0x5896F80", VA = "0x185897F80")]
	public static OBGJACJFCAK<T> ACIDFILIHBK(int HDEDDOIEPID = 0, int OBGIPLPBHFA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5898060", Offset = "0x5897060", VA = "0x185898060")]
	public static OBGJACJFCAK<T> AIMHHBBGHCE(int HDEDDOIEPID = 0, int OBGIPLPBHFA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5898940", Offset = "0x5897940", VA = "0x185898940")]
	public OBGJACJFCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x58987B0", Offset = "0x58977B0", VA = "0x1858987B0")]
	public OBGJACJFCAK(int HDEDDOIEPID, int OBGIPLPBHFA = int.MaxValue, bool HAPPEOIAABD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5898630", Offset = "0x5897630", VA = "0x185898630")]
	public T LHJKIDHMHHP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5898490", Offset = "0x5897490", VA = "0x185898490")]
	public void ECPMCGAOIHB(T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5898560", Offset = "0x5897560", VA = "0x185898560")]
	private void GBGMCBFPJFA(T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5898140", Offset = "0x5897140", VA = "0x185898140")]
	private void APKICJFNGNJ(T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5898350", Offset = "0x5897350", VA = "0x185898350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5898160", Offset = "0x5897160", VA = "0x185898160")]
	private void BJJBBFHJIFK(IEnumerable<T> NCIPNLHDHEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class BHIJHONLLIM<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> PBIFPLDBICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T EKGJONCCFDC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T PJLDOMOADMI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x643B120", Offset = "0x643A120", VA = "0x18643B120")]
	public bool KNDFACNEOHH(T IOALKPFEKEK, int PAAKFDIMFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x490D980", Offset = "0x490C980", VA = "0x18490D980")]
	public bool KDIFOBEKNMA(int PAAKFDIMFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x643B190", Offset = "0x643A190", VA = "0x18643B190")]
	public T PPEAGONJFHB(int KDFHGCMEENN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x643AF80", Offset = "0x6439F80", VA = "0x18643AF80")]
	private bool CDEFLICCJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x643AE90", Offset = "0x6439E90", VA = "0x18643AE90")]
	public bool BOIPBPENDNC(int PAAKFDIMFIA, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x490E1A0", Offset = "0x490D1A0", VA = "0x18490E1A0")]
	public BHIJHONLLIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class IELCIANCOPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct FODKEJOGMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T BDJLGAHJNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int FLLGNJHECIA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<FODKEJOGMGL> CJKBEHPOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T PODKMPPCBMN;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4474990", Offset = "0x4473990", VA = "0x184474990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5013520", Offset = "0x5012520", VA = "0x185013520")]
	public bool MBIHOFJOLNE(T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5012CD0", Offset = "0x5011CD0", VA = "0x185012CD0")]
	public void DOPEKGIEJEC(T IOALKPFEKEK, int PAAKFDIMFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5013370", Offset = "0x5012370", VA = "0x185013370")]
	public bool LKIPLGLLFFP(T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x50131E0", Offset = "0x50121E0", VA = "0x1850131E0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5012E60", Offset = "0x5011E60", VA = "0x185012E60")]
	public T FADGLAKKNFB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5012EF0", Offset = "0x5011EF0", VA = "0x185012EF0")]
	protected void FIBDKIBEJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x50138F0", Offset = "0x50128F0", VA = "0x1850138F0")]
	public IELCIANCOPC()
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
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x81318F0", Offset = "0x81308F0", VA = "0x1881318F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8131BC0", Offset = "0x8130BC0", VA = "0x188131BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8131AD0", Offset = "0x8130AD0", VA = "0x188131AD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x8131840", Offset = "0x8130840", VA = "0x188131840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x8131B10", Offset = "0x8130B10", VA = "0x188131B10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x8131A20", Offset = "0x8130A20", VA = "0x188131A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x81317B0", Offset = "0x81307B0", VA = "0x1881317B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5C579D0", Offset = "0x5C569D0", VA = "0x185C579D0", Slot = "4")]
		public virtual T CEIGNIKBILI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface DMOGBKINMJH
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache HJOFLFAPNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct GPPNIGGBECL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> KKAPDLIJLLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool JIHKHAINFED;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1A08DD0", Offset = "0x1A07DD0", VA = "0x181A08DD0")]
			public GPPNIGGBECL(List<Component> KKAPDLIJLLM, bool JIHKHAINFED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4EFF020", Offset = "0x4EFE020", VA = "0x184EFF020")]
			public LHIBIFOGMNG<T> GHDHEBFDHCI()
			{
				return default(LHIBIFOGMNG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4EFF080", Offset = "0x4EFE080", VA = "0x184EFF080", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x4EFF080", Offset = "0x4EFE080", VA = "0x184EFF080", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct LHIBIFOGMNG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> KKAPDLIJLLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool JIHKHAINFED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int HLGKMAPOEBE;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T AJOLFNCECJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x5478D50", Offset = "0x5477D50", VA = "0x185478D50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x5478CE0", Offset = "0x5477CE0", VA = "0x185478CE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5478D20", Offset = "0x5477D20", VA = "0x185478D20")]
			public LHIBIFOGMNG(List<Component> KKAPDLIJLLM, bool JIHKHAINFED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x5478C20", Offset = "0x5477C20", VA = "0x185478C20", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x5478C30", Offset = "0x5477C30", VA = "0x185478C30", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x48E8BE0", Offset = "0x48E7BE0", VA = "0x1848E8BE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8133620", Offset = "0x8132620", VA = "0x188133620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8133410", Offset = "0x8132410", VA = "0x188133410")]
		private void OCOPJMCPGIB(GameObject NCNIBCLAAID, bool HOJOMGEINAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8133380", Offset = "0x8132380", VA = "0x188133380")]
		public static void OCOPJMCPGIB(GameObject NCNIBCLAAID, ToolHierarchyCache HMLPKMOGHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8133580", Offset = "0x8132580", VA = "0x188133580")]
		public void OGLLJECKMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x401BF20", Offset = "0x401AF20", VA = "0x18401BF20")]
		public void DLOANDLBFOA<T>(Action<T> DMHPHEGJKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x401BEB0", Offset = "0x401AEB0", VA = "0x18401BEB0")]
		public T APKDBHPKKFA<T>(bool JIHKHAINFED = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x401C140", Offset = "0x401B140", VA = "0x18401C140")]
		public GPPNIGGBECL<T> KPBIJDBBLAC<T>(bool JIHKHAINFED = false) where T : class
		{
			return default(GPPNIGGBECL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8132FF0", Offset = "0x8131FF0", VA = "0x188132FF0")]
		public List<Component> HGFKDIDEBGK(Type BJLNCBFOGNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8132F00", Offset = "0x8131F00", VA = "0x188132F00", Slot = "4")]
		public bool Equals(ToolHierarchyCache OEFDFBLCHHF, ToolHierarchyCache GDBEEAKMPMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8132F80", Offset = "0x8131F80", VA = "0x188132F80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PGIOEBKALDP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class ALOGDJHCFDI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int HDEDDOIEPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int GDLFANLDDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> LFNABJKONLK;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4D77670", Offset = "0x4D76670", VA = "0x184D77670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T KBDAEPHICEN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x526FB90", Offset = "0x526EB90", VA = "0x18526FB90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T DMJAKMCEDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x526FEF0", Offset = "0x526EEF0", VA = "0x18526FEF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T KANCLDMKBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x526FD00", Offset = "0x526ED00", VA = "0x18526FD00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5270050", Offset = "0x526F050", VA = "0x185270050")]
	public ALOGDJHCFDI(int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x526F960", Offset = "0x526E960", VA = "0x18526F960")]
	public void DOPEKGIEJEC(T DPJKLOCGILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x526FDE0", Offset = "0x526EDE0", VA = "0x18526FDE0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x526FF90", Offset = "0x526EF90", VA = "0x18526FF90")]
	public void PCBBOFNDIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x526FB40", Offset = "0x526EB40", VA = "0x18526FB40")]
	public void EPMPFHMHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x526FF80", Offset = "0x526EF80", VA = "0x18526FF80")]
	public void OAHDPKLGFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x526FE20", Offset = "0x526EE20", VA = "0x18526FE20")]
	public List<T> NEMILBKOEED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MENADNEACFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct OEIEFDNLNFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int FLLGNJHECIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T BDJLGAHJNPH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, OEIEFDNLNFL> PBIFPLDBICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> GCFDNGHNPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T EKGJONCCFDC;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T PJLDOMOADMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE60260", Offset = "0xE5F260", VA = "0x180E60260", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x56ADE70", Offset = "0x56ACE70", VA = "0x1856ADE70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool ILLFPDOKKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x56AF810", Offset = "0x56AE810", VA = "0x1856AF810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object JILAMHKIPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x56AFCA0", Offset = "0x56AECA0", VA = "0x1856AFCA0")]
	public bool KNDFACNEOHH(T IOALKPFEKEK, object GFDDDAIMFOH, int PAAKFDIMFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x56AF880", Offset = "0x56AE880", VA = "0x1856AF880")]
	public bool KDIFOBEKNMA(object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x56AE1B0", Offset = "0x56AD1B0", VA = "0x1856AE1B0")]
	public bool BOIPBPENDNC(object GFDDDAIMFOH, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x56AF850", Offset = "0x56AE850", VA = "0x1856AF850")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x56AF270", Offset = "0x56AE270", VA = "0x1856AF270")]
	private bool CDEFLICCJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x56AFDE0", Offset = "0x56AEDE0", VA = "0x1856AFDE0")]
	public MENADNEACFB()
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
